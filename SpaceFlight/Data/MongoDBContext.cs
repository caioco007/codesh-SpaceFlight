using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using SpaceFlight.Entities;
using SpaceFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceFlight.Data
{
    public class MongoDBContext : DbContext
    {
        public MongoDBContext(DbContextOptions<MongoDBContext> options)
              : base(options)
        {
        }
        //public MongoDBContext(IConfiguration configuration)
        //{
        //    var client = new MongoClient(configuration.GetValue<string>
        //        ("DatabaseSettings:ConnectionString"));
        //    var database = client.GetDatabase(configuration.GetValue<string>
        //        ("DatabaseSettings:DatabaseName"));
        //    Articles = database.GetCollection<ArticlesModel>(configuration.GetValue<string>
        //        ("DatabaseSettings:CollectionName"));
        //    MongoDBContextSeed.SeedData(Articles);
        //}
        //public IMongoCollection<ArticlesModel> Articles { get;

        public DbSet<Models.ArticlesModel> Articles { get; set; }

        internal object Entry<T>()
        {
            throw new NotImplementedException();
        }
    }
}
