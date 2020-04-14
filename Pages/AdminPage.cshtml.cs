using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
namespace StrongBartending.Pages
{
    //Needs to be Admin to see the page
    [Authorize(Roles = "Admin")]
    public class AdminPageModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}