using SuperHeroDB.Shared;
using System.Net.Http.Json;

namespace SuperHeroDB.Client.Services
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly HttpClient _httpClient;

        public SuperHeroService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<SuperHero>> CreateSuperHero(SuperHero hero)
        {
            var result = await _httpClient.PostAsJsonAsync($"api/superhero", hero);
            var heroes = await result.Content.ReadFromJsonAsync<List<SuperHero>>();
            return heroes;
        }

        public async Task<SuperHero> GetSuperHero(int id)
        {
            return await _httpClient.GetFromJsonAsync<SuperHero>($"api/superhero/{id}");
        }

        public async Task<List<SuperHero>> GetSuperHeroes()
        {
            return await _httpClient.GetFromJsonAsync<List<SuperHero>>("api/superhero");
        }
    }
}
