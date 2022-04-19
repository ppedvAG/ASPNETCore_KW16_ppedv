using ASPNETCore_RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul001
{
    public class DISample1Model : PageModel
    {
        public IRequestCounter RequestCounter { get; set; } 

        //Konstruktor Injection, Zugriff auf IOC Container -> GetRequiredService()
        public DISample1Model(IRequestCounter requestCounter)
        {
            RequestCounter = requestCounter;
        }

        public void OnGet()
        {
            RequestCounter.Anzahl++;
        }

        private void WeitereLogik()
        {
            //
        }
    }
}
