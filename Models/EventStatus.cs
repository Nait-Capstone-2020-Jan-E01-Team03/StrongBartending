using System;
using System.Collections.Generic;

namespace StrongBartending
{
    public partial class EventStatus
    {
        public EventStatus()
        {
            Events = new HashSet<Events>();
        }

        public int EventStat { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Events> Events { get; set; }
    }
}
