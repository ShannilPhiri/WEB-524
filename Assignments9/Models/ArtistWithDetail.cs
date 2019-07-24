using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignments9.Models
{
    public class ArtistWithDetail : ArtistBase
    {
        public ArtistWithDetail()
        {
            Albums = new List<AlbumBase>();
        }

        public IEnumerable<AlbumBase> Albums { get; set; }
        public string Portrayl { get; set; }
    }
}