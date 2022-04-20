using ASPNETCore_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace ASPNETCore_RazorPages.Pages.Modul008
{
    public class SessionSampleStartModel : PageModel
    {
        public void OnGet()
        {
            //Zahlen und Strings kann die Session verwenden
            HttpContext.Session.SetInt32("age", 33);
            HttpContext.Session.SetString("Mitarbeiter", "Donald Duck");

            Movie movie = new Movie { Id = 123, Title = "Coda", Description = "Film einer Musikerin in einer Familie mit Hörproblem", Price = 19.99m, Genre = GenreTyp.Drama };

            string jsonString = JsonSerializer.Serialize(movie);
            HttpContext.Session.SetString("MovieDesMonats", jsonString);
        }
    }
}
