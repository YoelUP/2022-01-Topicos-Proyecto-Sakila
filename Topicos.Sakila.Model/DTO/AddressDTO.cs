using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.Model.DTO
{
    internal class AddressDTO
    {
        public byte AddressId { get; set; }
        public string District { get; set; } = null!;
    }
}
