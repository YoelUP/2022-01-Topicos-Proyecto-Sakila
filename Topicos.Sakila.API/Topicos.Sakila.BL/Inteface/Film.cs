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

        public Model.Models.FilmDTO? BuscarPorIdDTO(ushort id)
        {
            var _repository = new Repository.Film();
            var _result = _repository.BuscarPorIdDTO(id);
            return _result;
        }
    }
}
