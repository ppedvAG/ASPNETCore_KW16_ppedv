using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_WebAPI.Controllers
{
    //https://localhost:12345/api/Intro
    [Route("api/[controller]")] //URL Segment 'api' wird verwendet, wenn man ein MVC - Projekt verwendet und in diesem Projekt WebAPI Controller implementieren muss
    [ApiController]
    public class IntroController : ControllerBase
    {
        private readonly ILogger<IntroController> _logger;

        //Konstructor Injection
        public IntroController(ILogger<IntroController> logger)
        {
            _logger = logger;
        }

        //Minimale Konvention von WebAPI mit der Bedienung das Get oder GetPerson mit im Methoden-Namen steht 
        [HttpGet("GetHelloWorld")]
        public string GetHelloWorld([FromServices] ILogger<IntroController> weitererLogger)
        {
            weitererLogger.LogInformation("Intro->Get wurde aufgerufen");

            // weitere möglichkeit für IOC Zugriff -> this.HttpContext.RequestServices.GetService
            // weitere möglichkeit für IOC Zugriff -> this.HttpContext.RequestServices.GetRequiredService

            //  weitere möglichkeit für IOC Zugriff -> this.HttpContext.RequestServices.CreateScope()

            return "Hello World";
        }


        [HttpGet("GetName")]
        public string GetName()
        {
            return "Max und Moritz";
        }

        [HttpGet("/GetAnimal")]
        public string GetAnimal()
        {
            return "Idefix";
        }
    }
}
