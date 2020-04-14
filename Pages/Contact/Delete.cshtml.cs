using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrongBartending;
using StrongBartending.Data;
using Microsoft.AspNetCore.Authorization;

namespace StrongBartending.Pages.Contact
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public DeleteModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Contacts Contacts { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contacts = await _context.Contacts.FirstOrDefaultAsync(m => m.ContactKey == id);

            if (Contacts == null)
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

            Contacts = await _context.Contacts.FindAsync(id);

            if (Contacts != null)
            {
                _context.Contacts.Remove(Contacts);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
