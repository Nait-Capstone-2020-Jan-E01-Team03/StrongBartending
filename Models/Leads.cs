using System;
using System.Collections.Generic;

namespace StrongBartending
{
    public partial class Leads
    {
        public int LeadKey { get; set; }
        public string LegacyId { get; set; }
        public int LeadStat { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public int EventType { get; set; }
        public int BarPayKey { get; set; }
        public int BarTypeKey { get; set; }
        public string Location { get; set; }
        public int Guests { get; set; }
        public string Theme { get; set; }
        public int ContactKey { get; set; }
        public int LinkKey { get; set; }
        public string Notes { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Contacts ContactKeyNavigation { get; set; }
    }
}
