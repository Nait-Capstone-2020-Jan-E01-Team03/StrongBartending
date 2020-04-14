using System;
using System.Collections.Generic;

namespace StrongBartending
{
    public partial class LeadStatus
    {
        public LeadStatus()
        {
            Leads = new HashSet<Leads>();
        }

        public int LeadStat { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Leads> Leads { get; set; }
    }
}
