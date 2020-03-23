using System;
using System.Collections.Generic;

namespace StrongBartending
{
    public partial class Contacts
    {
        public Contacts()
        {
            Leads = new HashSet<Leads>();
        }

        public int ContactKey { get; set; }
        public short Active { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Leads> Leads { get; set; }
    }
}
