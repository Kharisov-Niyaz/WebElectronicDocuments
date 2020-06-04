using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class PathToFile
    {
        public int Id { get; set; }
        public string Basepath { get; set; }
        public string DebugBasepath { get; set; }
        public string Username { get; set; }
        public string FreeInstallDir { get; set; }
        public string LastVersions { get; set; }
        public string Drive { get; set; }
        public string Mysqlserver { get; set; }
        public string Servertype { get; set; }
        public string Sitename { get; set; }
        public string ExportDir { get; set; }
        public string SetupsDir { get; set; }
        public string ModsDir { get; set; }
        public string BaseType { get; set; }
        public string ProgramFiles { get; set; }
        public string DebugBaseType { get; set; }
        public string ConfigsPath { get; set; }
        public string DirectoryExists { get; set; }
        public string Backup { get; set; }
        public string DebugDirectoryExists { get; set; }
        public string DebugContract { get; set; }
        public string Contract { get; set; }
        public string Config2base { get; set; }
        public string Config { get; set; }
        public string TripExcelFile { get; set; }
        public string PathToLocalPc { get; set; }
        public bool? SaveOnLocalPc { get; set; }
    }
}
