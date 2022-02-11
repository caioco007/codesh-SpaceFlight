using MongoDB.Driver;
using SpaceFlight.Entities;
using SpaceFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceFlight.Data
{
    public class MongoDBContextSeed
    {
        public static void SeedData(IMongoCollection<ArticlesModel> articleCollection)
        {
            bool existArticle = articleCollection.Find(p => true).Any();
            if (!existArticle)
            {
            }
        }
    }
}
