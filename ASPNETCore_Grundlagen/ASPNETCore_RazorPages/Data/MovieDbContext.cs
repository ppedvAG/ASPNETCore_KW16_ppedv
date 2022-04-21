using ASPNETCore_RazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCore_RazorPages.Data
{
    public class MovieDbContext : DbContext
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options">ConnectionString wird an DbContext übergeben</param>
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            :base(options)
        {

           
        }


        //Der Name der Property repräsentiert den Tabellenamen in der zukünftigen Datenbank 
        public DbSet<Movie> Movies { get; set; }
    }
}
