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
using Microsoft.AspNetCore.Authorization;

namespace StrongBartending.Pages.Contact
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public EditModel(StrongBartending.Data.StrongBartendingContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Contacts.Modified = DateTime.Now;
            _context.Attach(Contacts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactsExists(Contacts.ContactKey))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ContactsExists(int id)
        {
            return _context.Contacts.Any(e => e.ContactKey == id);
        }
    }
}
