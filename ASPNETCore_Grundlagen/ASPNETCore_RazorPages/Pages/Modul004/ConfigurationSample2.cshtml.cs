using ASPNETCore_RazorPages.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace ASPNETCore_RazorPages.Pages.Modul004
{
    public class ConfigurationSample2Model : PageModel
    {
        public readonly GameSettings GameConfigSettings;

        //IOptionsSnapshot lädt Aktualisierungen in der Config (zur Laufzeit) nach
        public ConfigurationSample2Model(IOptionsSnapshot<GameSettings> gameSettings)
        {
            GameConfigSettings = gameSettings.Value;
        }
        public void OnGet()
        {

        }
    }
}
