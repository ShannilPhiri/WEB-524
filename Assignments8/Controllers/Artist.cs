using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignments8.Controllers
{
    public class Artist
    {
        [Required]
        [StringLength(128)]
        [Display(Name = "Artist Name or Stage Name")]
        public string Name { get; set; }

        [StringLength(128)]
        [Display(Name = "If Applicable, Artists's Birth Name")]
        public string BirthName { get; set; }

        [Display(Name = "Birth Date, or Start Date")]
        public DateTime BirthOrStartDate { get; set; }

        [StringLength(128)]
        [Display(Name = "Executive Who Looks")]
        public string Executive { get; set; }

        [Display(Name = "Artist Photo")]
        public string UrlArtist { get; set; }

        public Artist()
        {
            BirthOrStartDate = DateTime.Now;
        }
    }

    public class ArtistForm : Artist
    {
        [Display(Name = "Artist Primary Genre")]
        public SelectList Genre { get; set; }
    }

    public class ArtistAdd : Artist
    {
        public string Genre { get; set; }
    }

    public class ArtistBase : Artist
    {
        [Key]
        public int Id { get; set; }

        [StringLength(128)]
        [Display(Name = "Artist Primary Genre")]
        public string Genre { get; set; }
    }

    public class ArtistDetail : ArtistBase
    {
        [Display(Name = "Number of Albums")]
        public IEnumerable<AlbumBase> Albums { get; set; }

        public ArtistDetail()
        {
            Albums = new List<AlbumBase>();
        }
    }
}
