using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.BL.Repository
{
    public interface IStore
    {
        Task<IList<Model.Models.Store>> ListarAsync();
    }
}
