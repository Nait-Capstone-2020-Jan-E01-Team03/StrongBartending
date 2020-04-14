using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StrongBartending;
using StrongBartending.Data;
using Microsoft.AspNetCore.Authorization;

namespace StrongBartending.Pages.Contact
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        //declar context
        public CreateModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Contacts Contacts { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            Contacts.Created = DateTime.Now;
            Contacts.Modified = DateTime.Now;

            //Add current data to contact and database, will call request Director and run this at Technical Service for more complexity.
            _context.Contacts.Add(Contacts);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
