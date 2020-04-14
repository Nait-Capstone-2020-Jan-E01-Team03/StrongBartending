using System;
using System.Collections.Generic;

namespace StrongBartending
{
    public partial class BarPays
    {
        public BarPays()
        {
            Leads = new HashSet<Leads>();
        }

        public int BarPayKey { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Leads> Leads { get; set; }
    }
}
