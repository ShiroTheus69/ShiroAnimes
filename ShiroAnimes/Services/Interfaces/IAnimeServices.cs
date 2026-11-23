using ShiroAnimes.Models;

namespace ShiroAnimes.Services.Interfaces
{
    public interface IAnimeServices
    {
        IEnumerable<Animes> GetAll(int page, int pageSize);
    }
}
