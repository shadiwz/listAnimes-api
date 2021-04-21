using System.Collections.Generic;

namespace ListaAnime.Services
{
    public interface IAnimeService
    {
        List<Anime> Get();
        Anime Get(string id);
        Anime Create(Anime anime);
        long Update(string id, Anime anime);
        long Remove(string id);

    }
}