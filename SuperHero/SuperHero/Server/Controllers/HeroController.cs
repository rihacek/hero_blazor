using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHero.Shared;

namespace SuperHero.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        //no database, so use a list for now
        static List<Comic> comics = new List<Comic>
        {
            new Comic { Name = "Marvel" },
            new Comic { Name = "DC"}
        };

        List<Hero> heroes = new List<Hero>
        {
            new Hero { FirstName = "Peter", LastName = "Parker", HeroName = "Spiderman", Comic = comics[0] },
            new Hero { FirstName = "Bruce", LastName = "Wayne", HeroName = "Batman", Comic = comics[1] }
        };

        public async Task<IActionResult> GetHeroes()
        {
            return Ok(heroes);
        }
    }
}
