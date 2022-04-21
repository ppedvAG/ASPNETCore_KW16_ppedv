using ASPNETCore_WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private readonly IVideoService videoService;
        public VideoController(IVideoService videoService)
        {
            this.videoService = videoService;
        }

        [HttpGet("{name}")]
        public async Task<ActionResult> Index(string name)
        {

            Stream stream = await videoService.GetVideoByName(name);

            return new FileStreamResult(stream, "video/mp4");
        }

    }
}
