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
    public class CreateModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public CreateModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }
        public Leads Leads { get; set; }

        [BindProperty]
        public EventDetails EventDetails { get; set; }

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

            _context.EventDetails.Add(EventDetails);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
