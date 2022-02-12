using Microsoft.EntityFrameworkCore;
using SpaceFlight.Interface.Repositorio;
using SpaceFlight.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceFlight.Data.Repositorio
{
    public class ArticlesRepositorio : IArticlesRepositorio
    {
        private readonly AppDBContext _context;

        public ArticlesRepositorio (AppDBContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(int id)
        {
            var articles = await _context.Articles.FindAsync(id);

            _context.Articles.Remove(articles);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ArticlesModel>> GetAllAsync()
        {

            return await _context.Articles
                                .OrderBy(x => x.Title)
                                .ToListAsync();   
        }

        public async Task<ArticlesModel> GetByIdAsync(int id)
        {


            return await _context.Articles
                         .FirstOrDefaultAsync(m => m.Id == id);

            //var articles = _context.Articles
            //             .FirstOrDefaultAsync(m => m.Id == id);

            //return await articles;

        }

        public async Task<ArticlesModel> CreateAsync(ArticlesModel article)
        {
            var newArticle = _context.Articles.Add(article);
            await _context.SaveChangesAsync();

            return newArticle.Entity;
        }

        public async Task<ArticlesModel> IsExistBdAsync(string title, int id)
        {
            var article = await _context.Articles
                    .FirstOrDefaultAsync(x => x.Title.Contains(title) && x.Id != id);

            return article;
        }

        public async Task<ArticlesModel> UpdateAsync(ArticlesModel article)
        {
            var editArticle = _context.Articles.Update(article);
            await _context.SaveChangesAsync();

            return editArticle.Entity;

        }

    }
}
