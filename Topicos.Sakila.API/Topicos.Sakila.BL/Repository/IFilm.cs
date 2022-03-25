using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.BL.Repository
{
    public interface IFilm
    {
        Task<IList<Model.Models.Film>> ListarAsync();
    }
}
