#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPNETCore_RazorPages.Data;
using ASPNETCore_RazorPages.Models;

namespace ASPNETCore_RazorPages.Pages.Modul005b
{
    public class CreateModel : PageModel
    {
        private readonly ASPNETCore_RazorPages.Data.SecondMovieDbContext _context;

        public CreateModel(ASPNETCore_RazorPages.Data.SecondMovieDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        
        
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            if (Movie.Title == "The Crow")
            {
                ModelState.AddModelError("Movie.Title", "Dieser Film steht auf dem Index");
            }
                
            //ModelState prüft Movie-Klasse richtig befüllt wurde (nach Data-Annotation Angaben)
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
