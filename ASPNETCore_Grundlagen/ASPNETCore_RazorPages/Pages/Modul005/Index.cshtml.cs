using ASPNETCore_RazorPages.Data;
using ASPNETCore_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCore_RazorPages.Pages.Modul005
{
    public class IndexModel : PageModel
    {
        private readonly MovieDbContext movieDbContext;

        public IList<Movie> Movies { get; set; }

        public IndexModel(MovieDbContext context)
        {
            movieDbContext = context;
        }

        public async Task OnGet()
        {
            Movies = await movieDbContext.Movies.ToListAsync();
        }
    }
}
