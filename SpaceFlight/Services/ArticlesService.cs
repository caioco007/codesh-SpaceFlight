using SpaceFlight.Interface.Repositorio;
using SpaceFlight.Interface.Service;
using SpaceFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceFlight.Services
{
    public class ArticlesService : IArticlesService
    {
        private readonly IArticlesRepositorio _repository;

        public ArticlesService(IArticlesRepositorio articlesRepositorio)
        {
            _repository = articlesRepositorio;
        }

        public async Task<ArticlesModel> CreateAsync(ArticlesModel article)
        {
            return await _repository.CreateAsync(article);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ArticlesModel>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<ArticlesModel> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<ArticlesModel> IsExistBdAsync(string title, int id)
        {
            return await _repository.IsExistBdAsync(title.Trim(), id);
        }

        public async Task<ArticlesModel> UpdateAsync(ArticlesModel article)
        {
            return await _repository.UpdateAsync(article);
        }
    }
}
