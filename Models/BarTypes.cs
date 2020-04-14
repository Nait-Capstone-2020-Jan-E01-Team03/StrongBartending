using System;
using System.Collections.Generic;

namespace StrongBartending
{
    public partial class BarTypes
    {
        public BarTypes()
        {
            Leads = new HashSet<Leads>();
        }

        public int BarTypeKey { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Leads> Leads { get; set; }
    }
}
