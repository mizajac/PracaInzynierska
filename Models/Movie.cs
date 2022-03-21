using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracaInz.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        [Display(Name = "Tytuł")]
        public string? Title { get; set; }
        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Gatunek")]
        public int GenreID { get; set; }
        [Display(Name = "Cena")]
        public decimal Price { get; set; }
        [Display(Name = "Baza danych")]
        public string? Database { get; set; }

        public virtual Genre Genres { get; set; }
    }
}
