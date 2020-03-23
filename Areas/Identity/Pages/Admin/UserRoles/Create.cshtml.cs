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

namespace StrongBartending.Areas.Identity.Pages.Admin.UserRoles
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public CreateModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

        ViewData["RoleId"] = new SelectList(_context.AspNetRoles, "Id", "Name");
        ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "UserName");
            return Page();
        }

        [BindProperty]
        public AspNetUserRoles AspNetUserRoles { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AspNetUserRoles.Add(AspNetUserRoles);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
