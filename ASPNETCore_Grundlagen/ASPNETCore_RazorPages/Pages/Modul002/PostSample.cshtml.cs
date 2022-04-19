using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul002
{
    public class PostSampleModel : PageModel
    {
        public int Ergebnis { get; set; } = 0;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            int a=0, b=0;

            //traditioneller Zugriff 
            //Request.Form["eins"];
            //Request.Form["zwei"];

            if (int.TryParse(Request.Form["eins"].FirstOrDefault(), out a) &&
                int.TryParse(Request.Form["zwei"].FirstOrDefault(), out b))
            {
                //Wenn wir uns hier drin befinden, hat 'a' und 'b' einen validen Integerwert oder 0

                Ergebnis = a + b; 
            }
        }
    }
}
