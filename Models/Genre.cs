using System.ComponentModel.DataAnnotations;

namespace PracaInz.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Movies = new HashSet<Movie>();
        }
        public int GenreID { get; set; }
        [Display(Name = "Nazwa gatunku")]
        public string? NameGenre { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
