using ListaAnime.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaAnime.Controllers
{
    [ApiController]
    [Route("listAnimes")]
    public class AnimeControler : ControllerBase
    {
        private IAnimeService _animeService;
        
        public AnimeControler(IAnimeService animeservice)
        {
            _animeService = animeservice;
        }

        [HttpPost]
        public Anime Post(Anime anime)
        {
            var animeResult = _animeService.Create(anime);
            return animeResult;
        }

        [HttpGet]
        public List<Anime> Get()
        {
            
            return _animeService.Get();
        }

        [HttpGet]
        [Route("{animeId}")]
        public Anime GetById(string animeId)
        {
            return _animeService.Get(animeId);
        }
        
        [HttpDelete]
        [Route("{animeId}")]
        public long DeletById(string animeId)
        {
            return _animeService.Remove(animeId);
        }

        [HttpPut]
        [Route("{animeId}")]
        public long UpdateById(string animeId, [FromBody] Anime anime)
        {
            return _animeService.Update(animeId, anime);
        }
    }
}
