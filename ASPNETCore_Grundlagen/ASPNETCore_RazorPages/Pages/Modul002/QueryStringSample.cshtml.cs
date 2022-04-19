using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul002
{
    public class QueryStringSampleModel : PageModel
    {
        //Get-Methode: Wenn der Browser etwas vom WebServer m�chte, wird die Get-Methode ausgef�hrt 

        public int Id { get; set; }

        //https://localhost:44363/Modul002/QueryStringSample?id=123
        public void OnGet(int id)
        {
            Id = id;
        }
    }
}
