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
    public class DeleteModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public DeleteModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EventDetails = await _context.EventDetails.FindAsync(id);

            if (EventDetails != null)
            {
                _context.EventDetails.Remove(EventDetails);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
