using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Trips
    {
        public int TripId { get; set; }
        public string TripManName { get; set; }
        public string TripTabNumber { get; set; }
        public string TripSection { get; set; }
        public string TripStatus { get; set; }
        public string TripLocation { get; set; }
        public string TripSrok { get; set; }
        public string TripDateFrom { get; set; }
        public string TripDateTo { get; set; }
        public string TripDocNumber { get; set; }
        public string TripContractId { get; set; }
        public string TripDocDate { get; set; }
        public string TripExecutor { get; set; }
        public int? TripAdvenStChek { get; set; }
    }
}
