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

    [ApiConventionType(typeof(DefaultApiConventions))] //Wird Klassenweit behandelt
    public class ConventionsController : ControllerBase
    {
        private readonly ShipDbContext _context;

        public ConventionsController(ShipDbContext context)
        {
            _context = context;
        }

        // GET: api/Conventions
        [HttpGet]
        //ProducesResponseType kann man manuell die StatusCodes mit angeben 
        [ProducesResponseType(typeof(Ship), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Ship), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Ship), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Ship), StatusCodes.Status226IMUsed)]


        public async Task<ActionResult<IEnumerable<Ship>>> GetShip()
        {
            return await _context.Ship.ToListAsync();
        }

        // GET: api/Conventions/5
        [HttpGet("{id}")]

        //ApiConventionMethod -> behinaltet eine Sammlung von ProducesResponseType
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<Ship>> GetShip(int id)
        {
            var ship = await _context.Ship.FindAsync(id);

            if (ship == null)
            {
                return NotFound();
            }

            return ship;
        }

        // PUT: api/Conventions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754


        /// <summary>
        /// Ein Schiff-Datensatz wird aktualisiert
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ship"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShip(int id, Ship ship)
        {
            if (id != ship.Id)
            {
                return BadRequest();
            }

            _context.Entry(ship).State = EntityState.Modified;

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

        // POST: api/Conventions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754


        /// <summary>
        /// Ein Schiff-Datensatz wird hinzugefügt
        /// </summary>
        /// <param name="ship">Neues Schiff</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Ship>> PostShip(Ship ship)
        {
            _context.Ship.Add(ship);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShip", new { id = ship.Id }, ship);
        }

        // DELETE: api/Conventions/5

        /// <summary>
        /// Ein Schiff-Datensatz wird gelöscht
        /// </summary>
        /// <param name="id">Zu löschendes Schiff</param>
        /// <returns></returns>
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
