using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.Model.Models
{
    public partial class Film
    {
        [NotMapped]
        public string _Length
        {
            get
            {
                var result = string.Empty;
                result += this.Length + " minutes";
                return result;
            }
            set { }
        }

        [NotMapped]
        public string _RentalRate
        {
            get
            {
                var result = string.Empty;
                result += "$" + this.RentalRate;
                return result;
            }
            set { }
        }

    }
}
