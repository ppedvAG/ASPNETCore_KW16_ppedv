using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Wdh_Tag1.Modul002
{
    //[BindProperties] 
    public class FormValuesToPageModelPropertiesModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            ViewData["confirmation"] = $"{Name}, information will be sent to {Email}";
        }
    }
}
