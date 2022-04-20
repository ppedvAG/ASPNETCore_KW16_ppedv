using System.Globalization;

namespace ASPNETCore_RazorPages.Models
{
    public class CultureSwitcherModel
    {
        //Aktuell selektierte Culture
        public CultureInfo CurrentUICulture { get; set; }

        //vorhandene Cultures
        public List<CultureInfo> SupportedCultures { get; set; }
    }
}
