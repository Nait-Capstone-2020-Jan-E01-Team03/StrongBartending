using System;
using System.Collections.Generic;

namespace StrongBartending
{
    public partial class EventTypes
    {
        public EventTypes()
        {
            Leads = new HashSet<Leads>();
        }

        public int EventTypeKey { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Leads> Leads { get; set; }
    }
}
