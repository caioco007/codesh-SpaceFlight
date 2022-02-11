using MongoDB.Driver;
using SpaceFlight.Entities;
using SpaceFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceFlight.Data
{
    public interface IMongoDBContext
    {
        IMongoCollection<ArticlesModel> Articles { get; }
    }
}
