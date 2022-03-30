using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.BL.Inteface
{
    public class Film
    {
        public async Task<IList<Model.Models.Film>> ListarAsync()
        {
            var _repository = new Repository.Film();
            var _result = await _repository.ListarAsync();
            return _result;
        }

        public Model.Models.FilmDTO? SearchByIdDTO(ushort id)
        {
            var _repository = new Repository.Film();
            var _result = _repository.SearchByIdDTO(id);
            return _result;
        }

        public Model.Models.FilmDTO? SearchByTitleDTO(string title)
        {
            var _repository = new Repository.Film();
            var _result = _repository.SearchByTitleDTO(title);
            return _result;
        }
    }
}
