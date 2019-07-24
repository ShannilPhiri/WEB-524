using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignments9.Models
{
    public class ArtistBase
    {
        public ArtistBase()
        {
            BirthOrStartDate = DateTime.Now;
            AlbumId = new List<int>();
            Executive = "n/a";

        }

        public int Id { get; set; }
        [Required, StringLength(200)]
        [DisplayName("Birth Name")]
        public string Name { get; set; }

        [Required, StringLength(200)]
        [DisplayName("Stage Name")]
        public string BirthName { get; set; }

        [Required, StringLength(200)]
        public string Executive { get; set; }

        [Required, StringLength(200)]
        [DisplayName("Artist Photo")]
        public string UrlArtist { get; set; }
        [DisplayName("Birth Or Start Date")]
        public DateTime BirthOrStartDate { get; set; }

        public IEnumerable<int> AlbumId;

        public string Genre { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Artist Portrayl")]
        public string Portrayl { get; set; }

    }
}