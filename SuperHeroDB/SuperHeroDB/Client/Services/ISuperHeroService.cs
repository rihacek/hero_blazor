using SuperHeroDB.Shared;

namespace SuperHeroDB.Client.Services
{
    public interface ISuperHeroService
    {
        event Action OnChange;
        List<Comic> Comics { get; set; }
        List<SuperHero> Heroes { get; set; }
        Task<List<SuperHero>> GetSuperHeroes();
        Task GetComics();
        Task<SuperHero> GetSuperHero(int id);
        Task<List<SuperHero>> CreateSuperHero(SuperHero hero);
        Task<List<SuperHero>> UpdateSuperHero(SuperHero hero, int id);
        Task<List<SuperHero>> DeleteSuperHero(int id);



    }
}
