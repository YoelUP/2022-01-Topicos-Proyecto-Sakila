using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.Model.Models
{
    public partial class Actor
    {
        [NotMapped]
        public string Fullname
        {
            get
            {
                var result = string.Empty;
                result += this.FirstName;
                result += " " + this.LastName;
                return result;
            }
            set
            {

            }
        }
    }
}
