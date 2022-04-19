using ASPNETCore_RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul001
{
    public class DISample4Model : PageModel
    {
        public IRequestCounter RequestCounter { get; set; } 

        public void OnGet()
        {
            //Exception, wenn Service nicht gefunden wird
            RequestCounter = this.HttpContext.RequestServices.GetRequiredService<IRequestCounter>();

            //Nuallable, wenn Service nicht gefunden wird
            RequestCounter = this.HttpContext.RequestServices.GetService<IRequestCounter>();
        }
    }
}
