using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaceFlight.Interface.Repositorio;
using SpaceFlight.Interface.Service;
using SpaceFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceFlight.Controllers
{
    [Route("/articles")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticlesService _articleService;

        public ArticlesController(IArticlesService service)
        {
            _articleService = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticlesModel>>> GetArticleModel()
        {
            var articles = await _articleService.GetAllAsync();
            return Ok(articles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ArticlesModel>> GetArticleModel(int id)
        {
            var articles = await _articleService.GetByIdAsync(id);
            if (articles is null) return NotFound();

            return Ok(articles);
        }

        [HttpPost]
        public async Task<ActionResult<ArticlesModel>> PostArticleModel([FromBody] ArticlesModel articles)
        {
            if (articles is null) return BadRequest("Invalid Article");

            var articlesCreated = await _articleService.CreateAsync(articles);

            return Ok(articlesCreated);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticleModel([FromBody] ArticlesModel articles)
        {
            if (articles is null) return BadRequest("Invalid Article");

            return Ok(await _articleService.UpdateAsync(articles));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticleModel(int id)
        {
            var article = await _articleService.GetByIdAsync(id);

            if (article == null)
            {
                return NotFound();
            }

            await _articleService.DeleteAsync(article.Id);
            return Ok();
        }
    }
}
