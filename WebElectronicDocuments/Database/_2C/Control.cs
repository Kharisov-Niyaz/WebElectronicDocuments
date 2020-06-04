using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Control
    {
        public int ControlId { get; set; }
        public int? ContractId { get; set; }
        public short? ControlType { get; set; }
        public string ControlText { get; set; }
        public DateTime? ControlDate { get; set; }
        public short? ControlDateType { get; set; }
        public string ControlIspolnit { get; set; }
        public short? ControlWatched { get; set; }
        public string ControlNote { get; set; }
        public short? ControlWorkDone { get; set; }
        public short? ControlDoneForAdmin { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string ControlItapCalPlana { get; set; }
        public int? ControlIspolnitCkeck { get; set; }
        public DateTime? ControlLastUpdate { get; set; }
        public string ControlCorol { get; set; }
    }
}
