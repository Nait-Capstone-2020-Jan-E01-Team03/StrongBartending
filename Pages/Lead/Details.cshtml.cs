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
    public class DetailsModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public DetailsModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        public Leads Leads { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Leads = await _context.Leads
                .Include(l => l.ContactKeyNavigation).FirstOrDefaultAsync(m => m.LeadKey == id);

            if (Leads == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
