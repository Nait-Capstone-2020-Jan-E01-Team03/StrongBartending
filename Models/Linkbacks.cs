using System;
using System.Collections.Generic;

namespace StrongBartending
{
    public partial class Linkbacks
    {
        public Linkbacks()
        {
            Leads = new HashSet<Leads>();
        }

        public int LinkKey { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public virtual ICollection<Leads> Leads { get; set; }
    }
}
