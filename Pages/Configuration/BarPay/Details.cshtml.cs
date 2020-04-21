using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrongBartending;
using StrongBartending.Data;

namespace StrongBartending.Pages.Configuration.BarPay
{
    public class DetailsModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public DetailsModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        public BarPays BarPays { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BarPays = await _context.BarPays.FirstOrDefaultAsync(m => m.BarPayKey == id);

            if (BarPays == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
