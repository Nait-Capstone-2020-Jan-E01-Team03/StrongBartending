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

namespace StrongBartending.Pages.Event
{
    public class EditModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public EditModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Events Events { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Events = await _context.Events
                .Include(e => e.ContactKeyNavigation)
                .Include(e => e.EventStatNavigation).FirstOrDefaultAsync(m => m.EventKey == id);

            if (Events == null)
            {
                return NotFound();
            }
           ViewData["ContactKey"] = new SelectList(_context.Contacts, "ContactKey", "CreatedBy");
           ViewData["EventStat"] = new SelectList(_context.EventStatus, "EventStat", "Description");
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

            _context.Attach(Events).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventsExists(Events.EventKey))
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

        private bool EventsExists(int id)
        {
            return _context.Events.Any(e => e.EventKey == id);
        }
    }
}
