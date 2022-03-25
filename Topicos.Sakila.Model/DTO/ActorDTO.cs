using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.Model.Models
{
    public partial class FilmActorDTO
    {
        public ushort ActorId { get; set; }
        public string ActorFirstName { get; set; } = null!;
        public string ActorLastName { get; set; } = null!;
    }
}
