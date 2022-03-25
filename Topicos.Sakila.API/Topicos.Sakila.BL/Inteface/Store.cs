using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.BL.Inteface
{
    public class Store
    {
        public async Task<IList<Model.Models.Store>> ListarAsync()
        {
            var _repository = new Repository.Store();
            var _result = await _repository.ListarAsync();
            return _result;
        }
    }
}
