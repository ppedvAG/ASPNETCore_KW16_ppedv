using ASPNETCore_WebAPI.Data;
using ASPNETCore_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ASPNETCore_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReturnTypesController : ControllerBase
    {
        private readonly ShipDbContext dbContext;

        public ReturnTypesController(ShipDbContext shipDbContext)
        {
            dbContext = shipDbContext;
        }


        #region Hilfmethoden
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        #endregion


        #region Native Datentypen (string, int, float ... ganze .NET Datentypen werden unterstützt
        [HttpGet("HelloWorld")]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [HttpGet("GetCurrentTime")]
        public ContentResult GetCurrentTime()
        {
            return Content(DateTime.Now.ToString());    
        }
        #endregion


        #region Complexe Ojekte / Liste
        [HttpGet("GetWeatherForecastObj")]
        public WeatherForecast GetWeatherForecastObj()
        {
            return new WeatherForecast() {  Date = DateTime.Now, Summary="sonnig", TemperatureC=33 };
        }

        [HttpGet("GetWeatherForecastList")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        #endregion

        #region IActionResult / ActionResult Sync

        [HttpGet("GetShipsWith_IActionResult")]
        public IActionResult GetShips_IActionResult()
        {
            Ship ship = new Ship(); 

            ship.Id = 1;
            ship.Brand = "Die Schiffsbauer";
            ship.Modell = "GorgeForge Modell";

            if (ship.Brand == "Die Entdecker")
            {
                return BadRequest(); //400 
            }

            if (ship.Id == 0)
                return NotFound();

            return Ok(ship);
        }


        [HttpGet("GetShipsWith_ActionResult")]
        public ActionResult GetShips_ActionResult()
        {
            Ship ship = new Ship();

            ship.Id = 1;
            ship.Brand = "Die Schiffsbauer";
            ship.Modell = "GorgeForge Modell";

            if (ship.Brand == "Die Entdecker")
            {
                return BadRequest(); //400 
            }

            if (ship.Id == 0)
                return NotFound();

            return Ok(ship);
        }



        #endregion

        #region IActionResult / ActionResult Async
        [HttpGet("GetShips_IActionResult_Asnyc")]
        public async Task<IActionResult> GetShips_IActionResult_Asnyc()
        {
            await Task.Delay(1000);

            Ship ship = new Ship();

            ship.Id = 1;
            ship.Brand = "Die Schiffsbauer";
            ship.Modell = "GorgeForge Modell";

            if (ship.Brand == "Die Entdecker")
            {
                return BadRequest(); //400 
            }

            if (ship.Id == 0)
                return NotFound();

            return Ok(ship);
        }


        [HttpGet("GetShips_ActionResult_Asnyc")]
        public async Task<ActionResult> GetShips_ActionResult_Asnyc()
        {
            await Task.Delay(1000);

            Ship ship = new Ship();

            ship.Id = 1;
            ship.Brand = "Die Schiffsbauer";
            ship.Modell = "GorgeForge Modell";

            if (ship.Brand == "Die Entdecker")
            {
                return BadRequest(); //400 
            }

            if (ship.Id == 0)
                return NotFound();

            return Ok(ship);
        }

        #endregion

        #region IEnumerable und IAsyncEnumerable 

        [HttpGet("GetCarIEnumerable")]
        public IEnumerable<Ship> GetShipIEnumerable()
        {
            Ship ship = new Ship() { Id = 1, Brand = "Die Entdecker", Modell = "Holzschiff" };
            Ship ship1 = new() { Id = 2, Brand = "ThyssenKrupp", Modell = "UBoot" };
            Ship ship2 = new() { Id = 3, Brand = "Die Schiffbauer", Modell = "Schiffstyp 1" };

            List<Ship> ships = new List<Ship>();    
            
            ships.Add(ship);
            ships.Add(ship1);
            ships.Add(ship2);

            foreach(Ship curentShip in ships)
                yield return curentShip; 

            //return ships;
        } //Methode wird hier verlassen 



        //In Verbindung mit Entity Framework, würde dieses Beispiel sich direkt an einem praktische Beispiel knüpfen 

        [HttpGet("GetShipIEnumerableAsync")]
        public async IAsyncEnumerable<Ship> GetShipIEnumerableAsync()
        {


            Ship ship = new Ship() { Id = 1, Brand = "Die Entdecker", Modell = "Holzschiff" };
            Ship ship1 = new() { Id = 2, Brand = "ThyssenKrupp", Modell = "UBoot" };
            Ship ship2 = new() { Id = 3, Brand = "Die Schiffbauer", Modell = "Schiffstyp 1" };

            List<Ship> ships = new List<Ship>();

            ships.Add(ship);
            ships.Add(ship1);
            ships.Add(ship2);

            //await foreach -> In Verbindung mit EFCore zeigbar
            foreach (Ship curentShip in ships)
            {
                await Task.Delay(1000);
                yield return curentShip;    
            }
        }

        //await forach in Verbindung mit -> dbContext.Ship.AsAsyncEnumerable();

        [HttpGet("GetShipIEnumerableAsync2")]
        public async IAsyncEnumerable<Ship> GetShipIEnumerableAsync2()
        {
            IAsyncEnumerable<Ship> ships = dbContext.Ship.AsAsyncEnumerable();

            //await foreach -> In Verbindung mit EFCore zeigbar
            await foreach (Ship curentShip in ships)
            {
                await Task.Delay(1000);
                yield return curentShip;
            }
        }
        #endregion
    }
}
