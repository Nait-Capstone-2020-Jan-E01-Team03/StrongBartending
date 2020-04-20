using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace StrongBartending.Models
{
    public partial class Services
    {
        public Services()
        {
            Leads = new HashSet<Leads>();
            EventDetails = new HashSet<EventDetails>();
        }

        public int? ServiceKey { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string UOM { get; set; }

        public virtual ICollection<Leads> Leads { get; set; }
        public virtual ICollection<EventDetails> EventDetails { get; set; }
    }
}

