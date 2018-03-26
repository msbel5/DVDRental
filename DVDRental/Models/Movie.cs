using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DVDRental.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Realese Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public int NumberAvailable { get; set; }
    }
}