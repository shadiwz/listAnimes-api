using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace ListaAnime
{
    public class Anime
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public List<string> Category { get; set; }
        public string Author { get; set; }
        public string Resume { get; set; }
        public string FavCharacter { get; set; }
    }
}
