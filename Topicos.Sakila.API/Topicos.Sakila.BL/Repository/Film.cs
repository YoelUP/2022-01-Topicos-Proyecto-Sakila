using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Topicos.Sakila.Model.Models;

namespace Topicos.Sakila.BL.Repository
{
    internal class Film : IFilm
    {
        private readonly sakilaContext _context = new();
        private readonly int _pageNumber = 0;
        private readonly int _pagesize = 10;
        private readonly Mapper _mapper;

        public Film()
        {
            _mapper = InitializeAutomapper();
        }

        public Film(int pagesize)
        {
            _pagesize = pagesize;
            _mapper = InitializeAutomapper();
        }

        public Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Model.Models.Film, Model.Models.FilmDTO>();
                cfg.CreateMap<Model.Models.FilmCategory, Model.Models.FilmCategoryDTO>();
                cfg.CreateMap<Model.Models.FilmActor, Model.Models.FilmActorDTO>();
            });
            var mapper = new Mapper(config);
            return mapper;
        }

        public async Task<IList<Model.Models.Film>> ListarAsync()
        {
            var result = await _context.Films.
                Skip(_pagesize * _pageNumber).Take(_pagesize).ToListAsync();
            return result;
        }

        public Model.Models.FilmDTO? SearchByIdDTO(ushort id)
        {
            Model.Models.FilmDTO? resultDTO = null;
            var result = _context.Films.Include(f => f.FilmCategories).ThenInclude(fc => fc.Category).
                Include(f => f.FilmActors).ThenInclude(fa => fa.Actor).FirstOrDefault(f => f.FilmId == id);
            if (result != null)
            {
                resultDTO = _mapper.Map<FilmDTO>(result);
            }
            return resultDTO;
        }

        public Model.Models.FilmDTO? SearchByTitleDTO(string title)
        {
            Model.Models.FilmDTO? resultDTO = null;
            var result = _context.Films.Include(f => f.FilmCategories).ThenInclude(fc => fc.Category).
                Include(f => f.FilmActors).ThenInclude(fa => fa.Actor).
                FirstOrDefault(f => f.Title == title);
            if (result != null)
            {
                resultDTO = _mapper.Map<FilmDTO>(result);
            }
            return resultDTO;
        }
    }
}
