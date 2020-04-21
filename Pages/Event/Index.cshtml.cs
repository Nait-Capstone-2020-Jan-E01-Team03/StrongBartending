using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrongBartending;
using StrongBartending.Data;

namespace StrongBartending.Pages.Event
{
    public class IndexModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public IndexModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        public IList<Events> Events { get;set; }

        public async Task OnGetAsync()
        {
            Events = await _context.Events
                .Include(e => e.LeadKeyNavigation)
                .Include(e => e.ContactKeyNavigation)
                .Include(e => e.EventStatNavigation).ToListAsync();
        }
    }
}
