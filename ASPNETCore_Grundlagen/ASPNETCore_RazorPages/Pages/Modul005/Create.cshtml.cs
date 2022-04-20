using ASPNETCore_RazorPages.Data;
using ASPNETCore_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages.Pages.Modul005
{
    public class CreateModel : PageModel
    {
        private readonly MovieDbContext movieDbContext;

        [BindProperty]
        public Movie Movie { get; set; }

        public CreateModel(MovieDbContext context)
        {
            movieDbContext = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            movieDbContext.Movies.Add(Movie);
            await movieDbContext.SaveChangesAsync();


            return RedirectToPage("./Index");
        }
    }
}
