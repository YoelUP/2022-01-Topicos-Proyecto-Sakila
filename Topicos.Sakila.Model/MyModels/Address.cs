using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.Model.MyModels
{
    internal class Addres
    {
        public string _Address
        {
            get
            {
                var result = string.Empty;
                result += this._Address + " direccion";
                return result;
            }
            set { }
        }

        public string _District
        {
            get
            {
                var result = string.Empty;
                result += "$" + this._District;
                return result;
            }
            set { }
        }

    }
}