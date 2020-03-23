﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StrongBartending;
using StrongBartending.Data;
using System.Web;
namespace StrongBartending.Pages.Lead
{
    public class CreateModel : PageModel
    {
        private readonly StrongBartending.Data.StrongBartendingContext _context;

        public CreateModel(StrongBartending.Data.StrongBartendingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ContactKey"] = new SelectList(_context.Contacts, "ContactKey", "FullName");
            return Page();
        }

        [BindProperty]
        public Leads Leads { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Leads.Created = DateTime.Now;
            Leads.Modified = DateTime.Now;
            _context.Leads.Add(Leads);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}