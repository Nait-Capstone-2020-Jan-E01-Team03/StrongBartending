using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrongBartending;
using StrongBartending.Data;

namespace StrongBartending.Pages.EventDetail
{
    public class DetailsModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public DetailsModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        public EventDetails EventDetails { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EventDetails = await _context.EventDetails
                .Include(e => e.LeadKeyNavigation)
                .Include(e => e.LineStatNavigation)
                .Include(e => e.ServiceKeyNavigation).FirstOrDefaultAsync(m => m.LineKey == id);

            if (EventDetails == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
