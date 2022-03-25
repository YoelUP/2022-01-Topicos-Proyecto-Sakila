using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.Model.Models
{
    public partial class FilmCategoryDTO
    {
        public byte CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;
    }
}
