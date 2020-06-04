using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.StaticFiles;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebElectronicDocuments.Classes;
using WebElectronicDocuments.Classes.Interfaces;
using WebElectronicDocuments.Database;
using static WebElectronicDocuments.Classes.DataModel;

namespace WebElectronicDocuments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocsController : ControllerBase
    {
        private readonly IJournal _journal;
        private readonly IDocJournal _docJournal;
        private readonly IDocFile _docFile;
        private readonly IDoc _doc;
        private readonly IStage _stage;

        public DocsController(
            IJournal journal,
            IDocFile docFile,
            IDoc doc,
            IDocJournal docJournal,
            IStage stage)
        {
            _journal = journal;
            _docJournal = docJournal;
            _docFile = docFile;
            _doc = doc;
            _stage = stage;
        }

        [HttpGet]
        [Route("GetDocFile/{userId}/{docId}/{fileName}")]
        public async Task<IActionResult> GetDocFile(int userId, int docId, string fileName)
        {
            if (fileName == "")
                return BadRequest();

            var fileExtension = Path.GetExtension(fileName);
            var fileProvider = new FileExtensionContentTypeProvider();
            if (!fileProvider.TryGetContentType(fileExtension, out string contentType))
            {
                return BadRequest($"Unable to find Content Type for file name with extension={fileExtension}.");
            }
            var memory = new MemoryStream();
            using (var stream = new FileStream(GetPathAndFilename(fileName, userId, docId), FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            await _docJournal.AddAsync(new DocJournal()
            {
                Message = $"Скачивание документа {fileName}",
                CreateDate = DateTime.Now,
                EventType = 2,
                DocId = docId,
                UserId = userId
            });
            await _journal.AddAsync(new UserJournal() { Message = $"Скачивание документа {fileName}", CreateDate = DateTime.Now, UserId = userId });
            return File(memory, contentType);
        }

        [HttpPost]
        [Route("UpdateDocStage/{userId}/{userStage}/{docId}/{newStage}")]
        public async Task<IActionResult> UpdateDocStage(int userId, int userStage, int docId, int newStage)
        {
            bool bSuccess = false;
            try
            {
                bSuccess = await _doc.UpdateStageAsync(
                    userStage: userStage,
                    docId: docId,
                    stageId: newStage);
                await _docJournal.AddAsync(new DocJournal()
                {
                    Message = $"Изменение стадии документа",
                    CreateDate = DateTime.Now,
                    EventType = newStage > 0 ? 0 : 1,
                    DocId = docId,
                    UserId = userId
                });
            }
            catch { }
            if (bSuccess)
                return Ok(bSuccess);
            return BadRequest();
        }

        [HttpPost]
        [Route("UpdateDocUrgency/{userId}/{docId}/{urgency}")]
        public async Task<IActionResult> UpdateDocUrgency(int userId, int docId, bool urgency)
        {
            bool bSuccess = false;
            try
            {
                bSuccess = await _doc.UpdateUrgencyAsync(
                     docId: docId,
                     urgency: urgency);
                await _docJournal.AddAsync(new DocJournal()
                {
                    Message = $"{ (urgency ? "Установка" : "Снятие")} срочности документа",
                    CreateDate = DateTime.Now,
                    EventType = 4,
                    DocId = docId,
                    UserId = userId
                });
            }
            catch { }
            if (bSuccess)
                return Ok(bSuccess);
            return BadRequest();
        }

        [HttpPost]
        [Route("UpdateDocNormalInspection/{docId}/{userId}")]
        public async Task<IActionResult> UpdateDocNormalInspection(int docId, int userId)
        {
            Tuple<bool, bool> bSuccess = new Tuple<bool, bool>(false, false);
            int NormalInspectionId = 0;
            try
            {
                bSuccess = await _doc.UpdateNormalInspectionAsync(
                    docId: docId,
                    userId: userId);

                await _docJournal.AddAsync(new DocJournal()
                {
                    Message = $"{(bSuccess.Item2 ? "Закреплен" : "Откреплен")} нормоконтролер",
                    CreateDate = DateTime.Now,
                    EventType = 5,
                    DocId = docId,
                    UserId = userId
                });
            }
            catch { }
            if (bSuccess.Item1)
                return Ok(bSuccess);
            else if (NormalInspectionId > 0)
                return BadRequest(new { message = "Документ уже закреплен за " });
            else
                return BadRequest();
        }

        [HttpGet]
        [Route("GetStageList")]
        public async Task<IActionResult> GetStageList()
        {
            try
            {               
                return Ok(JsonConvert.SerializeObject(await _stage.GetAsync()));
            }
            catch { }
            return BadRequest();
        }

        [HttpGet]
        [Route("GetDocsList/{userId}/{userStage}/{groupId}/{userHead}")]
        public async Task<IActionResult> GetDocsList(int userId, int userStage, int groupId, bool userHead)
        {
            try
            {
                return Ok(await _doc.GetDocsAsync(
                    userId: userId,
                    groupId: groupId,
                    head: userHead,
                    stageId: userStage));
            }
            catch
            {

            }
            return BadRequest();
        }

        [HttpGet]
        [Route("GetSearchDocsList/{userId}/{searchValue}")]
        public async Task<IActionResult> GetSearchDocsList(int userId, string searchValue)
        {
            try
            {
                var GetSearchDocsListTask = Task.Run(() =>
                {
                    Thread.Sleep(1000);

                });
                await GetSearchDocsListTask;
                return Ok();
            }
            catch
            {

            }
            return BadRequest();
        }

        [HttpGet]
        [Route("GetDocJournalList/{userId}/{docId}")]
        public async Task<IActionResult> GetDocJournalList(int userId, int docId)
        {
            try
            {
                return Ok(await _docJournal.GetDocJournalsAsync(docId));
            }
            catch { }
            return BadRequest();
        }

        [HttpPost]
        [Route("UploadData/{userId}/{docId}")]
        public async Task<IActionResult> UploadData([FromForm]IList<IFormFile> files, int userId, int docId)
        {
            bool bSuccess = false;

            try
            {
                foreach (IFormFile source in files)
                {
                    string filename = ContentDispositionHeaderValue.Parse(source.ContentDisposition).FileName.ToString().Trim('"');
                    filename = this.EnsureCorrectFilename(filename);
                    string filePath = this.GetPathAndFilename(filename, userId, docId);
                    using (FileStream output = System.IO.File.Create(filePath))
                        await source.CopyToAsync(output);
                    /*await _docFile.AddAsync(new DocFile()
                    {
                        DocId = docId,
                        Name = filename,
                        Path = filePath
                    });*/
                    await _doc.UpdateFileAsync(
                        docId: docId,
                        fileName: filename
                        );
                    await _docJournal.AddAsync(new DocJournal()
                    {
                        Message = $"Загрузка документа {filename}",
                        CreateDate = DateTime.Now,
                        EventType = 3,
                        DocId = docId,
                        UserId = userId
                    });
                }
                bSuccess = true;
            }
            catch { }
            if (bSuccess)
                return Ok(bSuccess);
            return BadRequest();
        }

        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);

            return filename;
        }

        private string GetPathAndFilename(string filename, int userId, int docId)
        {
            string path = String.Format("{0}\\uploads\\{1}\\{2}\\", Directory.GetCurrentDirectory(), userId, docId);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return path + filename;
        }
    }
}