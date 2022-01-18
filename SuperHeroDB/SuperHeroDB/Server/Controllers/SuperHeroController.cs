using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroDB.Shared;

namespace SuperHeroDB.Server.Controllers
{
    //item within brackets in the route references the name of the controller item: <this string>Controller
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        static List<Comic> comics = new List<Comic> {
            new Comic { Name = "Marvel"},
            new Comic { Name = "DC"}
        };

        List<SuperHero> heroes = new List<SuperHero> {
            new SuperHero { Id = 1, FirstName = "Peter", LastName = "Parker", HeroName = "Spiderman", Comic = comics[0]},
            new SuperHero { Id = 2, FirstName = "Bruce", LastName = "Wayne", HeroName = "Batman", Comic = comics[1]}
        };

        [HttpGet]
        public async Task<IActionResult> GetSuperHeroes()
        {
            return Ok(heroes);
            //best practice here would actually be to add services with interfaces
            //inject the service with a constructor here in the controller 
            //call a method from the service and the service makes the db call
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleSuperHero(int id)
        {
            var hero = heroes.FirstOrDefault(h => h.Id == id);
            if (hero == null)
                return NotFound("Super Hero wasn't; found. Too bad. :D");

            return Ok(hero);
        }
    }
}
