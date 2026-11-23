using Microsoft.AspNetCore.Mvc;
using ShiroAnimes.Models;
using ShiroAnimes.Services;
using ShiroAnimes.Services.Interfaces;

namespace ShiroAnimes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimesController : ControllerBase
    {
        private readonly IAnimeServices _animeServices;

        public AnimesController(IAnimeServices animeServices)
        {
            _animeServices = animeServices;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Animes>> GetAll(
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 20)
        {
            if (page < 1)
                page = 1;

            if (pageSize < 1)
                pageSize = 20;

            if (pageSize > 100)
                pageSize = 100;

            var animes = _animeServices.GetAll(page, pageSize);

            return Ok(animes);
        }
    }
}
