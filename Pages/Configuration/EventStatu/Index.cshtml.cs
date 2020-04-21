using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrongBartending;
using StrongBartending.Data;

namespace StrongBartending.Pages.Configuration.EventStatu
{
    public class IndexModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public IndexModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        public IList<EventStatus> EventStatus { get;set; }

        public async Task OnGetAsync()
        {
            EventStatus = await _context.EventStatus.ToListAsync();
        }
    }
}
