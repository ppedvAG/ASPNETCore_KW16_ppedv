using ASPNETCore_RazorPages.Models;

namespace ASPNETCore_RazorPages.Data
{
    public static class DataSeeder
    {
        public static void SeedMovieStoreDb(MovieDbContext context)
        {
            if (!context.Movies.Any())
            {
                //Hier Datensatz wird markiert zum hinzufügen in unsere DB
                context.Movies.Add(new Movie { Title = "Coda", Description = "Singtalent", Genre = GenreTyp.Drama, Price = 12.99m });
                context.Movies.Add(new Movie { Title = "King Richard", Description = "Serena und Venus Williams", Genre = GenreTyp.Biogrpahy, Price = 19.99m });
                context.Movies.Add(new Movie { Title = "Batman", Description = "Batman Film", Genre = GenreTyp.Action, Price = 17.99m });
                context.SaveChanges();
            }

        }
    }
}
