using ASPNETCore_RazorPages.Data;
using ASPNETCore_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCore_RazorPages.Pages.Modul005
{
    public class DetailsModel : PageModel
    {

        private readonly MovieDbContext movieDbContext;

        public Movie Movie { get; set; }

        public DetailsModel(MovieDbContext context)
        {
            movieDbContext = context;
        }


        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
                return NotFound();


            Movie = await movieDbContext.Movies.FirstOrDefaultAsync(m => m.Id == id);


            if (Movie == null)
                return NotFound();

            return Page();
        }
    }
}
