using SuperHeroDB.Shared;

namespace SuperHeroDB.Client.Services
{
    public interface ISuperHeroService
    {
        Task<List<SuperHero>> GetSuperHeroes();
        Task<SuperHero> GetSuperHero(int id);
        Task<List<SuperHero>> CreateSuperHero(SuperHero hero);

    }
}
