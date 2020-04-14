using System;
using System.Collections.Generic;

namespace StrongBartending
{
    public partial class Services
    {
        public Services()
        {
            EventDetails = new HashSet<EventDetails>();
        }

        public int ServiceKey { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Uom { get; set; }

        public virtual ICollection<EventDetails> EventDetails { get; set; }
    }
}
