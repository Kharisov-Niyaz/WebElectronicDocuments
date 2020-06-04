using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebElectronicDocuments.Classes.Interfaces;
using WebElectronicDocuments.Database;
using WebElectronicDocuments.Database._2C;

namespace WebElectronicDocuments.Classes.Repository
{
    public class RDoc : IDoc
    {
        private readonly _2cContext _2CContext;
        private readonly WedContext _context;
        private readonly IUser _user;
        public RDoc(_2cContext _2CContext, WedContext dbContext, IUser user)
        {
            this._2CContext = _2CContext;
            this._context = dbContext;
            this._user = user;
        }

        async Task<Contracts> GetContractAsync(int? contractId)
        {
            return await _2CContext.Contracts.AsQueryable().
                         Where(wr => wr.ContractId == contractId).FirstOrDefaultAsync();
        }
        async Task<Customers> GetCustomerAsync(int? customerId)
        {
            return await _2CContext.Customers.AsQueryable().
                         Where(wr => wr.CustomerId == customerId).FirstOrDefaultAsync();
        }
        async Task<Executors> GetExecutorAsync(int? executorId)
        {
            return await _2CContext.Executors.AsQueryable().
                         Where(wr => wr.ExecutorId == executorId).FirstOrDefaultAsync();
        }
        async Task<CalPlan> GetCalPlanAsync(int? contractId, string stageNumber)
        {
            return await _2CContext.CalPlan.AsQueryable().
                         Where(wr => wr.ContractId == contractId &&
                                     wr.NumberOfStages == stageNumber).FirstOrDefaultAsync();
        }
        async Task<List<Control>> GetControlsByIdAsync(int[] docsId)
        {
            return await _2CContext.Control.AsQueryable().
                             Where(wr => docsId.Any(an => an == wr.ControlId)
                             ).OrderByDescending(or => or.ControlDate).ToListAsync();
        }
        async Task<List<Control>> GetControlsAsync(string userName)
        {
            return await _2CContext.Control.AsQueryable().
                             Where(wr => wr.ControlIspolnit == userName &&
                             (wr.ControlIspolnitCkeck == 1 || wr.ControlIspolnitCkeck == null) &&
                             wr.ControlDateType == 1 &&
                             (wr.ControlType == 0 || wr.ControlType == 4) &&
                             wr.ControlWorkDone == 0
                             ).OrderByDescending(or => or.ControlDate).ToListAsync();
        }
        async Task<DataModel.DocAction> GetDocActionAsync(int docId)
        {
            DataModel.DocAction docAction = await _context.DocActions.
                                            Where(wr => wr.DocId == docId).FirstOrDefaultAsync();
            if (docAction == null)
            {
                docAction = new DataModel.DocAction();
                docAction.DocId = -1;
                docAction.NormalInspectionId = 0;
                docAction.StageId = 1;
                docAction.Update = false;
                docAction.Urgency = false;
                docAction.FileName = "";
            }
            return docAction;
        }
        public async Task<List<DataModel.Doc>> GetDocsAsync(int userId, int groupId, bool head, int stageId)
        {
            List<Control> data = new List<Control>();
            if (stageId > 1)
            {
                int[] docsId = await _context.DocActions.AsQueryable().
                               Where(wr => wr.StageId == stageId).
                               Select(s => s.DocId).ToArrayAsync();
                data = await this.GetControlsByIdAsync(docsId);

            }
            else
            {
                string userName = await _2CContext.ControlUsers.AsQueryable().Where(wr => wr.ControlUserId == userId).
                                        Select(s => s.ControlUserName).FirstAsync();
                data = await this.GetControlsAsync(userName);
                if (head)
                {
                    Dictionary<int, string> users = await _user.GetHeadUsersAsync(groupId);
                    foreach (KeyValuePair<int, string> user in users)
                    {
                        if (user.Key != userId)
                            data.AddRange(await this.GetControlsAsync(user.Value));
                    }
                }
            }

            List<DataModel.Doc> docs = new List<DataModel.Doc>();
            foreach (var item in data)
            {
                Contracts contract = await this.GetContractAsync(item.ContractId);
                if (contract != null)
                {
                    if (contract.ContractControlIspolnitel == null ||
                        contract.ContractControlIspolnitel == 1)
                    {
                        Customers customer = await this.GetCustomerAsync(contract.CustomerId);
                        Executors executor = await this.GetExecutorAsync(contract.ContractExecutorId);
                        CalPlan calPlan = await this.GetCalPlanAsync(item.ContractId, item.ControlItapCalPlana);
                        string docNote = calPlan == null ? contract.ContractNote : $"Этап №{calPlan.NumberOfStages}: {calPlan.NameOfWork}";

                        DataModel.Doc doc = new DataModel.Doc();
                        doc.Id = item.ControlId;
                        doc.InitiatorName = item.ControlIspolnit;
                        doc.Customer = customer.CustomerName;
                        doc.Name = contract.ContractExecutorId != 7 ? contract.ContractNumber : contract.ContractWorkNote;
                        doc.Description = docNote;
                        doc.Executor = executor.ExecutorName;
                        doc.CreateDate = contract.ContractDate ?? DateTime.Now;
                        doc.CloseDate = item.ControlDate ?? DateTime.Now;
                        doc.Payment = contract.ContractPaid != null ? Convert.ToBoolean(contract.ContractPaid) : false;
                        doc.DocAction = await this.GetDocActionAsync(item.ControlId);
                        docs.Add(doc);
                    }
                }
            }
            return docs;
        }

        public async Task<bool> AddDocActionsAsync(DataModel.DocAction docAction)
        {
            _context.Entry(docAction).State = EntityState.Added;
            return (await _context.SaveChangesAsync()) > 0;
        }
        async Task<DataModel.DocAction> CheckExist(int docId)
        {
            DataModel.DocAction docAction = await this.GetDocActionAsync(docId);
            if (docAction.DocId < 0)
            {
                docAction.DocId = docId;
                bool success = await this.AddDocActionsAsync(docAction);
                if (!success)
                    return null;
            }
            return docAction;
        }
        public async Task<bool> UpdateStageAsync(int userStage, int docId, int stageId)
        {
            DataModel.DocAction docAction = await this.CheckExist(docId);
            if (docAction == null)
                return false;

            if (userStage == 3 && stageId < 0) docAction.StageId = 1;
            else docAction.StageId += stageId;
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<bool> UpdateUrgencyAsync(int docId, bool urgency)
        {
            DataModel.DocAction docAction = await this.CheckExist(docId);
            if (docAction == null)
                return false;
            docAction.Urgency = urgency;
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Tuple<bool, bool>> UpdateNormalInspectionAsync(int docId, int userId)
        {
            DataModel.DocAction docAction = await this.CheckExist(docId);
            if (docAction == null)
                return new Tuple<bool, bool>(false, false);
            bool fix = docAction.NormalInspectionId == 0;
            docAction.NormalInspectionId = fix ? userId : 0;
            return new Tuple<bool, bool>((await _context.SaveChangesAsync()) > 0, fix);
        }

        public async Task<bool> UpdateFileAsync(int docId, string fileName)
        {
            DataModel.DocAction docAction = await this.CheckExist(docId);
            if (docAction == null)
                return false;
            docAction.FileName = fileName;
            return (await _context.SaveChangesAsync()) > 0;
        }

    }
}
