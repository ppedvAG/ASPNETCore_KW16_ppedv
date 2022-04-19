using ASPNETCore_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul003
{
    public class RazorSyntaxSamplesModel : PageModel
    {
        public string Username { get; set; }

        public Person[] Peoples { get; set; }    

        public void OnGet()
        {
            Username = "Max Muster";
            Peoples = new Person[] { new Person("Max", 21), new Person("Sandra", 23), new Person("Andre", 41) };
        }

       
    }
}
