using System;
using System.Collections.Generic;

namespace anabolicdata.Models
{
    public partial class Reports
    {
        public int ReportId { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public string Conditions { get; set; }
        public string Bloodwork { get; set; }
        public string Compound { get; set; }
        public int? Dose { get; set; }
        public int? Duration { get; set; }
        public string SideEffects { get; set; }
        public string Notes { get; set; }
    }
}
