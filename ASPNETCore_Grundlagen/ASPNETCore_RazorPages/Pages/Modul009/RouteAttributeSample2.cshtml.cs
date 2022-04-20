using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul009
{
    public class RouteAttributeSample2Model : PageModel
    {
        public IActionResult OnGet()
        {
            //OnGetABC wird angesteuert.
            return RedirectToPage("RouteAttributesDestinationSample", "ABC",
                new { year = 2021, month = 6, day = 12, title = "herr der ringe" });
        }
    }
}
