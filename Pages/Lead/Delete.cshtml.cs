using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrongBartending;
using StrongBartending.Data;

namespace StrongBartending.Pages.Lead
{
    public class DeleteModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public DeleteModel(StrongBartending.Data.StrongBartendingContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Leads = await _context.Leads.FindAsync(id);

            if (Leads != null)
            {
                _context.Leads.Remove(Leads);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
