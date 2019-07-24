using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignments8.Models
{
    // Add your design model classes below

    // Follow these rules or conventions:

    // To ease other coding tasks, the name of the integer identifier property should be "Id"
    // Collection properties (including navigation properties) must be of type ICollection<T>
    // Valid data annotations are pretty much limited to [Required] and [StringLength(n)]
    // Required to-one navigation properties must include the [Required] attribute
    // Do NOT configure scalar properties (e.g. int, double) with the [Required] attribute
    // Initialize DateTime and collection properties in a default constructor


    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Name { get; set; }


    }

    public class RoleClaim
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
    }

    public class Album
    {
        public Album()
        {
            ReleaseDate = DateTime.Now;
            Artists = new List<Artist>();
            Tracks = new List<Track>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Name { get; set; }

        [Required]
        [StringLength(120)]
        public string Coordinator { get; set; }

        [StringLength(120)]
        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string UrlAlbum { get; set; }

        public ICollection<Artist> Artists { get; set; }

        public ICollection<Track> Tracks { get; set; }

       
    }

    
    public class Artist
    {
       

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Name { get; set; }

        [StringLength(120)]
        public string BirthName { get; set; }

        public DateTime BirthOrStartDate { get; set; }

        [StringLength(120)]
        public string Executive { get; set; }


        public string UrlArtist { get; set; }

        [StringLength(120)]
        public string Genre { get; set; }


        public ICollection<Album> Albums { get; set; }

    
    }

    
    public class Track
    {

        public Track()
        {
            Albums = new List<Album>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Name { get; set; }

        [StringLength(120)]
        public string Clerk { get; set; }

        [StringLength(120)]
        public string Composers { get; set; }

        [StringLength(120)]
        public string Genre { get; set; }

        public ICollection<Album> Albums { get; set; }

    }


}


