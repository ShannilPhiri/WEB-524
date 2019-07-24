using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignments9.Models
{
    public class AlbumBase
    {
        
            public AlbumBase()
            {
                ReleaseDate = DateTime.Now;
                Coordinator = "n/a";
            }


            public int id { get; set; }

            [Required, StringLength(200)]
            [DisplayName("Album Name")]
            public string Name { get; set; }

            [Required, StringLength(200)]
            [DisplayName("Album Photo")]
            public string UrlAlbum { get; set; }

            [Required, StringLength(200)]
            public string Genre { get; set; }

            [Required, StringLength(200)]
            public string Coordinator { get; set; }

            public DateTime ReleaseDate { get; set; }

            public IEnumerable<int> ArtistIds { get; set; }
            public IEnumerable<int> TrackId { get; set; }

            [DataType(DataType.MultilineText)]
            [DisplayName("Album Depiction")]
            public string Depiction { get; set; }
    }
}