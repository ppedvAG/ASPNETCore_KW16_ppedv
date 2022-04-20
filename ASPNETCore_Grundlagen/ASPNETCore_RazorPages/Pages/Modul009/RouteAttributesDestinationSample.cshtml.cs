using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul009
{
    public class RouteAttributesDestinationSampleModel : PageModel
    {
        //Ohne PageHandler
        public void OnGet(int year, int month, int day, string title)
        {

        }

        //Mit Page-Hanlder
        public void OnGetABC(int year, int month, int day, string title)
        {

        }
    }
}
