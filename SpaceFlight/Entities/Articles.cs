using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceFlight.Entities
{
    public class Articles
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        public bool Featured { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string NewsSite { get; set; }
        public string Summary { get; set; }
        public string PublishedAt { get; set; }

        public List<Launches> Launches { get; set; }
        public List<Events> Events { get; set; }
    }
}
