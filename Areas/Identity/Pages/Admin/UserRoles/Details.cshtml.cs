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

namespace StrongBartending.Areas.Identity.Pages.Admin.UserRoles
{
    [Authorize(Roles = "Admin")]
    public class DetailsModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public DetailsModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        public AspNetUserRoles AspNetUserRoles { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AspNetUserRoles = await _context.AspNetUserRoles
                .Include(a => a.Role)
                .Include(a => a.User).FirstOrDefaultAsync(m => m.UserId == id);

            if (AspNetUserRoles == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
