using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul009
{
    public class RouteTemplatesSampleModel : PageModel
    {
        //https://localhost:44363/Modul009/RouteTemplatesSample/2021/11/13/HerrDerRinge
        public void OnGet(int year, int month, int day, string title)
        {
        }
    }
}
