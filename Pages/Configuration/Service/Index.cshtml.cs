using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrongBartending.Data;
using StrongBartending.Models;

namespace StrongBartending.Pages.Configuration.Service
{
    public class IndexModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public IndexModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        public IList<Services> Services { get;set; }

        public async Task OnGetAsync()
        {
            Services = await _context.Services.ToListAsync();
        }
    }
}
