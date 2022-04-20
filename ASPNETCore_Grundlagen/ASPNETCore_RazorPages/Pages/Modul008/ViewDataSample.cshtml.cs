using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul008
{
    public class ViewDataSampleModel : PageModel
    {
        public void OnGet()
        {
            ViewData.Add("Email", "KevinW@ppedv.de");

            ViewData["Name"] = "Kevin";
        }
    }
}
