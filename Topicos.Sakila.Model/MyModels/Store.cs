using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.Model.MyModels
{
    internal class Store
    {
        public string Fullname
        {
            get
            {
                var result = string.Empty;
                result += this.Costumers;
                result += " " + this.AddresId;
                return result;
            }
            set
            {

            }
        }
    }
}

