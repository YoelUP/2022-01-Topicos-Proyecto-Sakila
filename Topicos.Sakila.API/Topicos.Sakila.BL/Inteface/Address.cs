using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.BL.Inteface
{
        public class Address
        {
            public async Task<IList<Model.Models.Address>> ListarAsync()
            {
                var _repository = new Repository.Address();
                var _result = await _repository.ListarAsync();
                return _result;
            }

            public Model.Models.AddressDTO? SearchByIdDTO(ushort id)
            {
                var _repository = new Repository.Address();
                var _result = _repository.SearchByIdDTO(id);
                return _result;
            }

            public Model.Models.AddressDTO? SearchByTitleDTO(string title)
            {
                var _repository = new Repository.Address();
                var _result = _repository.SearchByTitleDTO(title);
                return _result;
            }
        }
}