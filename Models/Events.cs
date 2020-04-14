using System;
using System.Collections.Generic;

namespace StrongBartending
{
    public partial class Events
    {
        public int EventKey { get; set; }
        public int EventStat { get; set; }
        public int ContactKey { get; set; }
        public DateTime Reminder { get; set; }
        public TimeSpan? BarOpen { get; set; }
        public TimeSpan? BarClose { get; set; }
        public decimal Hours { get; set; }
        public int StaffCount { get; set; }
        public string Notes { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Gst { get; set; }
        public decimal Gratuity { get; set; }
        public decimal Total { get; set; }

        public virtual Contacts ContactKeyNavigation { get; set; }
        public virtual EventStatus EventStatNavigation { get; set; }
    }
}
