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

        public EventDetails EventDetail { get; set; }
        public IList<EventDetails> EventDetails { get; set; }
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
                Leads.LeadStat = 8;
                _context.Attach(Leads).State = EntityState.Modified;

                EventDetails = await _context.EventDetails
                    .Include(e => e.LeadKeyNavigation)
                    .Include(e => e.LineStatNavigation)
                    .Include(e => e.ServiceKeyNavigation).ToListAsync();

                EventDetails = EventDetails.Where(e => e.LeadKey == id).ToList();

                foreach (EventDetails items in EventDetails)
                { 
                    if(items.LeadKey==Leads.LeadKey)
                    {
                        items.LineStat = 5;
                        _context.Attach(items).State = EntityState.Modified;
                    }
                
                }

                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
