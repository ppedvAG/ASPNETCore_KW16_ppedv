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

namespace ASPNETCore_RazorPages.Pages.Wdh_Tag2
{
    public class CreateModel : PageModel
    {
        private readonly ASPNETCore_RazorPages.Data.SecondMovieDbContext _context;

        public CreateModel(SecondMovieDbContext context)
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
            if (!ModelState.IsValid)
            {
                return Page();
            }


            //Datensatz wird zum Hinzufügen markiert
            _context.Movie.Add(Movie);

            //Wird SQL Erstellt und an DB übertragen
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
