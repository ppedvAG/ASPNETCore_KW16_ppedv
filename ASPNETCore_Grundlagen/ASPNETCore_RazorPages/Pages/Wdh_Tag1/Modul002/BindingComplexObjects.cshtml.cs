using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Wdh_Tag1.Modul002
{
    public class BindingComplexObjectsModel : PageModel
    {
        [BindProperty]
        public Login Login { get; set; }


        public void OnGet()
        {
            ViewData["welcome"] = $"Welcome {Login.Email}";
        }
    }


    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
