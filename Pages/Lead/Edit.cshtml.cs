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

namespace StrongBartending.Pages.Lead
{
    public class EditModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public EditModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Leads Leads { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Leads = await _context.Leads
                .Include(l => l.BarPayKeyNavigation)
                .Include(l => l.BarTypeKeyNavigation)
                .Include(l => l.ContactKeyNavigation)
                .Include(l => l.EventTypeKeyNavigation)
                .Include(l => l.LeadStatNavigation)
                .Include(l => l.LinkKeyNavigation).FirstOrDefaultAsync(m => m.LeadKey == id);

            if (Leads == null)
            {
                return NotFound();
            }
           ViewData["BarPayKey"] = new SelectList(_context.BarPays, "BarPayKey", "Description");
           ViewData["BarTypeKey"] = new SelectList(_context.BarTypes, "BarTypeKey", "Description");
           ViewData["ContactKey"] = new SelectList(_context.Contacts, "ContactKey", "FullName");
           ViewData["EventTypeKey"] = new SelectList(_context.EventTypes, "EventTypeKey", "Description");
           ViewData["LeadStat"] = new SelectList(_context.LeadStatus, "LeadStat", "Description");
           ViewData["LinkKey"] = new SelectList(_context.Linkbacks, "LinkKey", "Name");
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
            Leads.Modified = DateTime.Now;
            Leads.ModifiedBy = User.Identity.Name;
            _context.Attach(Leads).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeadsExists(Leads.LeadKey))
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

        private bool LeadsExists(int id)
        {
            return _context.Leads.Any(e => e.LeadKey == id);
        }
    }
}
