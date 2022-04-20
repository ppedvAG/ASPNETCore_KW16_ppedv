using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul008
{
    public class TempDataSampleModel : PageModel
    {
        public void OnGet()
        {
            if (!TempData.ContainsKey("Message"))
                TempData.Add("Message", "Hallo liebe Teilnehmer");
        }
    }
}
