using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        [HttpGet]
        public About GetAboutInfo()
        {
            string jsonText = System.IO.File.ReadAllText("./Data/about.json");
            return JsonConvert.DeserializeObject<About>(jsonText);
        }
    }
}