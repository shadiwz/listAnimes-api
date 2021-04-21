using ListaAnime.Services;
using MongoDB.Driver;
using System.Collections.Generic;

namespace ListaAnime.Services
{
    public class AnimeService: IAnimeService
    {
        private readonly IMongoCollection<Anime> _anime;

        public AnimeService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _anime = database.GetCollection<Anime>(settings.CollectionName);
        }

        public List<Anime> Get()
        {
            return _anime.Find(anime => true).ToList();
        }

        public Anime Get(string id)
        {
            return _anime.Find<Anime>(anime => anime.Id == id).FirstOrDefault();
        }

        public Anime Create(Anime anime)
        {
            _anime.InsertOne(anime);
            return anime;
        }

        public long Update(string id, Anime animeIn)
        {
            return _anime.ReplaceOne(anime => anime.Id == id, animeIn).ModifiedCount;
        }

        public void Remove(Anime animeIn)
        {
            _anime.DeleteOne(anime => anime.Id == animeIn.Id);
        }

        public long Remove(string id)
        {
            var animes = _anime.DeleteOne(anime => anime.Id == id);
            return animes.DeletedCount;
        }
    }
}