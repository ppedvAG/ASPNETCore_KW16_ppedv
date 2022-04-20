#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNETCore_RazorPages.Models;

namespace ASPNETCore_RazorPages.Data
{
    public class SecondMovieDbContext : DbContext
    {
        public SecondMovieDbContext (DbContextOptions<SecondMovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNETCore_RazorPages.Models.Movie> Movie { get; set; }
    }
}
