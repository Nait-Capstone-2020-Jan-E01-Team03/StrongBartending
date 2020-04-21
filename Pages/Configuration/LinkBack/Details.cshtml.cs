using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrongBartending;
using StrongBartending.Data;

namespace StrongBartending.Pages.Configuration.LinkBack
{
    public class DetailsModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public DetailsModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        public Linkbacks Linkbacks { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Linkbacks = await _context.Linkbacks.FirstOrDefaultAsync(m => m.LinkKey == id);

            if (Linkbacks == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
