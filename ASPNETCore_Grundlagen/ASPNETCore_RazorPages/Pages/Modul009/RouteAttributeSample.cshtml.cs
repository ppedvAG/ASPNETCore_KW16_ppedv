using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul009
{
    public class RouteAttributeSampleModel : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("RouteAttributesDestinationSample", new { year = 2021, month = 6, day = 12, title = "herr der ringe" });
        }
    }
}
