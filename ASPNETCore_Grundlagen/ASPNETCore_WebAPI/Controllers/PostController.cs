using ASPNETCore_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        //POST = Hinzufügen eines Datensatzes 
        [HttpPost("InsertShipDefault")] 
        public IActionResult InsertShipDefault (Ship ship) //Hier wird das Schiff im HTTP-Package Body mitgeliefert und ist nicht via URL einsichtbar
        {
            //Speichere Datensatz

            return Ok();
        }

        [HttpPost("InsertShipAsQueryParameter")]
        public IActionResult InsertShipAsQuery([FromQuery] Ship ship) //Eingebaewerte kommen aus der URL (QueryString) und werden in ein Objekt gemappt (Parameter-Modelbinding)
        {
            //Speichere Datensatz

            return Ok();
        }


        [HttpPost("InsertStringAsQuery")]
        public IActionResult InsertString1(string name)
        {
            //string 

            return Ok();
        }

        [HttpPost("InserStringViaBody")]
        public IActionResult InsertString2([FromBody] string fromBody)
        {
            //string

            return Ok();
        }


        [HttpPut]
        public IActionResult UpdateShip(int id, Ship ship) //Ids müssen gegengeprüft werden
        {
            if (id != ship.Id)
                return BadRequest();

            return Ok();    
        }


    }
}
