using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Wdh_Tag1.Modul002
{
    public class TheProblemModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            var name = Request.Form["Name"];
            var email = Request.Form["Email"];
            
            ViewData["confirmation"] = $"{name}, information will be sent to {email}";
        }
    }
}
