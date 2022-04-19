using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul002
{
    public class FromRouteSampleModel : PageModel
    {
        public int Id { get; set; }

        
        public void OnGet([FromRoute] int id)
        {
            Id = id;
        }
    }
}
