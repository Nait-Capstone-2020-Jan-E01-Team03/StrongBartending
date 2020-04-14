using System;
using System.Collections.Generic;

namespace StrongBartending
{
    public partial class LineStatus
    {
        public LineStatus()
        {
            EventDetails = new HashSet<EventDetails>();
        }

        public int LineStat { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EventDetails> EventDetails { get; set; }
    }
}
