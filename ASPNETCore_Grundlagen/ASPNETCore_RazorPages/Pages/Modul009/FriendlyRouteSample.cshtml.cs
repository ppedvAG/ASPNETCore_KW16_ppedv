using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul009
{
    public class FriendlyRouteSampleModel : PageModel
    {
        //https://localhost:44363/Post/2021/7/13/ChessOpenings
        public void OnGet(int year, int month, int day, string title)
        {
        }
    }
}
