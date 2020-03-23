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
    public class IndexModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public IndexModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        public IList<AspNetUserRoles> AspNetUserRoles { get;set; }

        public async Task OnGetAsync()
        {
            AspNetUserRoles = await _context.AspNetUserRoles
                .Include(a => a.Role)
                .Include(a => a.User).ToListAsync();
        }
    }
}
