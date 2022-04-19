using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul002
{
    public class PageHandlerSampleModel : PageModel
    {
        public string Einstieg { get; set; } 

        public void OnGet()
        {
            Einstieg = "OnGet";
        }



        //  https://localhost:44363/Modul002/PageHandlerSample?handler=Demo
        //  https://localhost:44363/Modul002/PageHandlerSample/Demo
        public void OnGetDemo()
        {
            Einstieg = "OnGetDemo";
        }


        //https://localhost:44363/Modul002/PageHandlerSample?handler=DemoWithParam&param=hello
        public void OnGetDemoWithParam(string param)
        {
            Einstieg = $"Page Handler with param {param}"; 
        }
    }
}
