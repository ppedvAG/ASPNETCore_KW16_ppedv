using ASPNETCore_WebAPI.Data;
using ASPNETCore_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCore_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaggingSortingController : ControllerBase
    {
        private readonly ShipDbContext _context;

        public PaggingSortingController(ShipDbContext context)
        {
            _context = context;
        }

        [HttpGet ("PagingListWithPageParameters")]



        //Wenn ich auf Seite 1 bin und drei ersten Datensätze sehen möchte -> pageNumber = 1 

        //Wenn ich auf Seite 2 bin, möchte ich die Datensätze 4,5,6 in meiner Liste zurückgeben
        public async Task<ActionResult<IEnumerable<Ship>>> GetShips(int pageNumber = 1, int pageSize = 3)
        {
            return await _context.Ship.OrderBy(e => e.Brand)
                                      .Skip((pageNumber - 1) * pageSize)
                                      .Take(pageSize).ToListAsync();
        }
    }
}
