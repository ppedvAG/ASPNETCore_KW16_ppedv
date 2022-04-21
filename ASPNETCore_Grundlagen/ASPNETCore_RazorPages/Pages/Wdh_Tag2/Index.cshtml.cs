#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNETCore_RazorPages.Data;
using ASPNETCore_RazorPages.Models;

namespace ASPNETCore_RazorPages.Pages.Wdh_Tag2
{
    public class IndexModel : PageModel
    {
        private readonly ASPNETCore_RazorPages.Data.SecondMovieDbContext _context;

        public IndexModel(ASPNETCore_RazorPages.Data.SecondMovieDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
