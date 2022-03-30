using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.Sakila.Model.Models
{
    public partial class FilmDTO
    {
        public FilmDTO()
        {
            FilmActors = new HashSet<FilmActorDTO>();
            FilmCategories = new HashSet<FilmCategoryDTO>();
        }

        public ushort FilmId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? _Length { get; set; }
        public short? ReleaseYear { get; set; }
        public string? Rating { get; set; }
        public string? _RentalRate { get; set; }

        public virtual ICollection<FilmActorDTO> FilmActors { get; set; }
        public virtual ICollection<FilmCategoryDTO> FilmCategories { get; set; }

    }
}
