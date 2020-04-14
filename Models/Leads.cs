using System;
using System.Collections.Generic;

namespace StrongBartending
{
    public partial class Leads
    {
        public Leads()
        {
            EventDetails = new HashSet<EventDetails>();
        }

        public int LeadKey { get; set; }
        public string LegacyId { get; set; }
        public int LeadStat { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public int EventTypeKey { get; set; }
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

        public virtual BarPays BarPayKeyNavigation { get; set; }
        public virtual BarTypes BarTypeKeyNavigation { get; set; }
        public virtual Contacts ContactKeyNavigation { get; set; }
        public virtual EventTypes EventTypeKeyNavigation { get; set; }
        public virtual LeadStatus LeadStatNavigation { get; set; }
        public virtual Linkbacks LinkKeyNavigation { get; set; }
        public virtual ICollection<EventDetails> EventDetails { get; set; }
    }
}
