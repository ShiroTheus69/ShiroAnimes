using ShiroAnimes.Models;
using ShiroAnimes.Services.Interfaces;
using System.Linq;

namespace ShiroAnimes.Services
{
    public class AnimeServices : IAnimeServices
    {
        public IEnumerable<Animes> GetAll(int page, int pageSize)
        {
            var CatalogoAnime = new List<Animes>
            {
                new Animes
                {
                    Id = 1, NomeAnime = "One Piece", GeneroAnime = "Shounen", AnoAnime = 1999
                },
                new Animes
                {
                    Id = 2, NomeAnime = "Attack on Titan", GeneroAnime = "Shounen", AnoAnime = 2013
                },
                new Animes
                {
                    Id = 3, NomeAnime = "Frieren", GeneroAnime = "Aventura", AnoAnime = 2023
                },
                new Animes
                {
                    Id = 4, NomeAnime = "Sword art Online", GeneroAnime = "Aventura", AnoAnime = 2012
                }
            };

            return CatalogoAnime
                .Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
