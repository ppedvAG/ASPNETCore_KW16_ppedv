using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul004
{
    public class ConfigurationSample1Model : PageModel
    {
        //IConfiguraiton beinhaltet alle Konfigurationen
        private readonly IConfiguration configuration; 
        
        public ConfigurationSample1Model(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //ContentResult liefert einen einfache String-Ausgabe
        public ContentResult OnGet()
        {
            //Explizietes auslesen via IConfiguration 
            string myKeyValue = configuration["MyKey"];
            string title = configuration["Position:Title"];
            string name = configuration["Position:Name"];

            string defaultLogLevel = configuration["Logging:LogLevel:Default"];

            return Content($"MyKey value: {myKeyValue} \n" +
                $"Title: {title} \n" +
                $"Name: {name} \n" +
                $"Default Log Level: {defaultLogLevel}");
        }
    }
}
