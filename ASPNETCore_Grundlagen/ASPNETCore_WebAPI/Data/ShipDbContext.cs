#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNETCore_WebAPI.Models;

namespace ASPNETCore_WebAPI.Data
{
    public class ShipDbContext : DbContext
    {
        public ShipDbContext (DbContextOptions<ShipDbContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNETCore_WebAPI.Models.Ship> Ship { get; set; }
    }
}
