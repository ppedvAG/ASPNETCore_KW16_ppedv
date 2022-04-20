using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul008
{
    public class ViewBagSampleModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Email"] = "KevinW@ppedv";
        }
    }
}
