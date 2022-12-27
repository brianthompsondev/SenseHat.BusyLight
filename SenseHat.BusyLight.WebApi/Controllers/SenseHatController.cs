using Microsoft.AspNetCore.Mvc;
using SenseHat.BusyLight.WebApi.Services;
using System.Drawing;
using System.Net;

namespace SenseHat.BusyLight.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SenseHatController : ControllerBase    
    {
        private readonly ISenseHatService senseHatService;

        public SenseHatController(ISenseHatService senseHatService)
        {
            this.senseHatService= senseHatService;
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]

        public ActionResult SetColor(string colorName)
        {
            var color = Color.FromName(colorName);
            if (color.IsKnownColor)
            {
                senseHatService.Fill(color);
                return Accepted();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
