using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StrongBartending;
using StrongBartending.Data;

namespace StrongBartending.Pages.EventDetail
{
    public class EditModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public EditModel(StrongBartending.Data.StrongBartendingContext context)
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
           ViewData["LeadKey"] = new SelectList(_context.Leads, "LeadKey", "CreatedBy");
           ViewData["LineStat"] = new SelectList(_context.LineStatus, "LineStat", "Description");
           ViewData["ServiceKey"] = new SelectList(_context.Services, "ServiceKey", "Description");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EventDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventDetailsExists(EventDetails.LineKey))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EventDetailsExists(int id)
        {
            return _context.EventDetails.Any(e => e.LineKey == id);
        }
    }
}
