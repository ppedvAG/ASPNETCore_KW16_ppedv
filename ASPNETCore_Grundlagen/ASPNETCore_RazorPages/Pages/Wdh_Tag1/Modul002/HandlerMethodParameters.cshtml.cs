using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Wdh_Tag1.Modul002
{
    public class HandlerMethodParametersModel : PageModel
    {
        public void OnGet()
        {
        }

        //Model-Binding von Variablen zur OnPost - Methode
        //Parameter-Variablenname muss selben Typ und Namen tragen, wie in 
        public void OnPost(string name, string email)
        {
            ViewData["confirmation"] = $"{name}, information will be sent to {email}";
        }
    }
}
