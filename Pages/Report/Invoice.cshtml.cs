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


namespace StrongBartending.Pages.Report
{
    public class InvoiceModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public InvoiceModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }
        public Leads Leads { get; set; }

        public Events Events { get; set; }

        public Contacts Contacts { get; set; }
        public IList<EventDetails> EventDetails { get; set; }

        public decimal subtotal = 0;

        public decimal GST = 0;

        public decimal Gratuity = 0;

        public decimal Total = 0;

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

            Events = await _context.Events
                .Include(e => e.ContactKeyNavigation)
                .Include(e => e.EventStatNavigation).FirstOrDefaultAsync(m => m.LeadKey == id);

            EventDetails = await _context.EventDetails
                .Include(e => e.LeadKeyNavigation)
                .Include(e => e.LineStatNavigation)
                .Include(e => e.ServiceKeyNavigation).ToListAsync();

            EventDetails = EventDetails.Where(e => e.LeadKey == id).ToList();

            foreach (EventDetails item in EventDetails)
            {
                subtotal = subtotal + item.Price;
            }
            subtotal = decimal.Round(subtotal, 2);

            GST = decimal.Round((subtotal * Convert.ToDecimal(0.05)), 2);

            Gratuity = decimal.Round((subtotal * Convert.ToDecimal(0.18)), 2);

            Total = decimal.Round((subtotal + GST + Gratuity), 2);

            Contacts = await _context.Contacts.FirstOrDefaultAsync(m => m.ContactKey == Leads.ContactKey);

            if (Leads == null)
            {
                return NotFound();
            }


            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            Leads = await _context.Leads
                .Include(l => l.BarPayKeyNavigation)
                .Include(l => l.BarTypeKeyNavigation)
                .Include(l => l.ContactKeyNavigation)
                .Include(l => l.EventTypeKeyNavigation)
                .Include(l => l.LeadStatNavigation)
                .Include(l => l.LinkKeyNavigation).FirstOrDefaultAsync(m => m.LeadKey == id);

            Leads.LeadStat = 5;

            _context.Attach(Leads).State = EntityState.Modified;

            Events = await _context.Events
                .Include(e => e.ContactKeyNavigation)
                .Include(e => e.EventStatNavigation).FirstOrDefaultAsync(m => m.LeadKey == id);

            Events.EventStat = 3;

            _context.Attach(Events).State = EntityState.Modified;

            EventDetails = await _context.EventDetails
                .Include(e => e.LeadKeyNavigation)
                .Include(e => e.LineStatNavigation)
                .Include(e => e.ServiceKeyNavigation).ToListAsync();

            EventDetails = EventDetails.Where(e => e.LeadKey == id).ToList();

            foreach (EventDetails item in EventDetails)
            {
                item.LineStat = 3;
            }

            _context.Attach(Events).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return RedirectToPage("/Event/Index");
        }
    }
}