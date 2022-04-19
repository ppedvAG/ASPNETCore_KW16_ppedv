using ASPNETCore_RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul001
{
    public class DISample2Model : PageModel
    {
        public IRequestCounter RequestCounter { get; set; }


        //Methoden Injection -> eher im MVC angesiedelt 

        public void OnGet([FromServices] IRequestCounter requestCounter )
        {
            RequestCounter = requestCounter;
            RequestCounter.Anzahl++;
        }
    }
}
