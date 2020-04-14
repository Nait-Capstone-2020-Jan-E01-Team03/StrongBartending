using System;
using System.Collections.Generic;

namespace StrongBartending
{
    public partial class EventDetails
    {
        public int LineKey { get; set; }
        public int LeadKey { get; set; }
        public int? EventKey { get; set; }
        public int LineStat { get; set; }
        public int? ServiceKey { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public virtual Leads LeadKeyNavigation { get; set; }
        public virtual LineStatus LineStatNavigation { get; set; }
        public virtual Services ServiceKeyNavigation { get; set; }
    }
}
