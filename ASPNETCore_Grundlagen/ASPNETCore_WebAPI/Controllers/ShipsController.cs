#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPNETCore_WebAPI.Data;
using ASPNETCore_WebAPI.Models;

namespace ASPNETCore_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipsController : ControllerBase
    {
        private readonly ShipDbContext _context;

        public ShipsController(ShipDbContext context)
        {
            _context = context;
        }

        // GET: api/Ships
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ship>>> GetShip()
        {
            return await _context.Ship.ToListAsync();
        }


        // GET: https://localhost:7077/api/Ships/GetShipById?id=3    -> müsste  [HttpGet("GetShipById")]

        /// <summary>
        /// Lese Schiffe aus ->  // GET: api/Ships/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]  //Id wird als Route-Template verwende 
        public async Task<ActionResult<Ship>> GetShip(int id) // [HttpGet("{id}")] muss GetShip(int id) den selben id-Namen aufweisen
        {
            var ship = await _context.Ship.FindAsync(id);

            if (ship == null)
            {
                return NotFound();
            }

            return ship;
        }

        // PUT: api/Ships/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        /// <summary>
        /// Aktualisiere Schiff
        /// </summary>
        /// <param name="id">identifier</param>
        /// <param name="ship">Schaff Datensatz</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShip(int id, Ship ship)
        {

            //Cross-Site Attack sollten hiermit unterbunden werden 
            if (id != ship.Id)
            {
                return BadRequest();
            }

            _context.Entry(ship).State = EntityState.Modified; //Schiffs-Entity wird als geändert markiert

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShipExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Ships
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ship>> PostShip(Ship ship)
        {
            _context.Ship.Add(ship);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShip", new { id = ship.Id }, ship); //Bekommen wir ein Ship-Object mit einer Id zurückgegeben (Response) 
        }

        // DELETE: api/Ships/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShip(int id)
        {
            var ship = await _context.Ship.FindAsync(id);
            if (ship == null)
            {
                return NotFound();
            }

            _context.Ship.Remove(ship);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShipExists(int id)
        {
            return _context.Ship.Any(e => e.Id == id);
        }
    }
}
