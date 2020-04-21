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
    public class CreateModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public CreateModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }
        public decimal subtotal = 0;

        public decimal GST = 0;

        public decimal Gratuity = 0;

        public decimal Total = 0;
        public Leads Leads { get; set; }

        public IList<EventDetails> EventDetails { get; set; }

        [BindProperty]
        public Events Events { get; set; }
        public Events EventsCreated { get; set; }

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

            EventDetails = await _context.EventDetails
                            .Include(e => e.LeadKeyNavigation)
                            .Include(e => e.LineStatNavigation)
                            .Include(e => e.ServiceKeyNavigation).ToListAsync();

            EventDetails = EventDetails.Where(e => e.LeadKey == id).ToList();


            foreach(EventDetails item in EventDetails)
            {
                subtotal = subtotal + item.Price;
            }

            subtotal = decimal.Round(subtotal, 2);

            GST = decimal.Round((subtotal * Convert.ToDecimal(0.05)),2);

            Gratuity = decimal.Round((subtotal * Convert.ToDecimal(0.18)),2);

            Total = decimal.Round((subtotal + GST + Gratuity),2);

            ViewData["ContactKey"] = new SelectList(_context.Contacts, "ContactKey", "FullName");
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
            Events.EventStat= 1;
            _context.Events.Add(Events);

            Leads = await _context.Leads
                .Include(l => l.BarPayKeyNavigation)
                .Include(l => l.BarTypeKeyNavigation)
                .Include(l => l.ContactKeyNavigation)
                .Include(l => l.EventTypeKeyNavigation)
                .Include(l => l.LeadStatNavigation)
                .Include(l => l.LinkKeyNavigation).FirstOrDefaultAsync(m => m.LeadKey == Events.LeadKey);

            Leads.LeadStat = 4;

            await _context.SaveChangesAsync();

            EventsCreated = await _context.Events
                .Include(e => e.ContactKeyNavigation)
                .Include(e => e.EventStatNavigation).FirstOrDefaultAsync(m => m.LeadKey == Events.LeadKey);

            EventDetails = await _context.EventDetails
                           .Include(e => e.LeadKeyNavigation)
                           .Include(e => e.LineStatNavigation)
                           .Include(e => e.ServiceKeyNavigation).ToListAsync();

            EventDetails = EventDetails.Where(e => e.LeadKey == Events.LeadKey).ToList();


            foreach (EventDetails item in EventDetails)
            {
                item.LineStat = 2;
                item.EventKey = EventsCreated.EventKey;
            }

            await _context.SaveChangesAsync();


            return RedirectToPage("./Index");
        }
    }
}
