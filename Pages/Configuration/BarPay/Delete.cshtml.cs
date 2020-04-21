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
    public class DeleteModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public DeleteModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BarPays = await _context.BarPays.FindAsync(id);

            if (BarPays != null)
            {
                _context.BarPays.Remove(BarPays);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
