using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Assignments9.Models
{
    public class AlbumWithDetail : AlbumBase
    {
        public AlbumWithDetail()
        {
            Artists = new List<ArtistBase>();
            Tracks = new List<TrackBase>();
        }

        [DisplayName("Number of Tracks in Album")]
        public IEnumerable<TrackBase> Tracks { get; set; }
        [DisplayName("Number of Artists in Album")]
        public IEnumerable<ArtistBase> Artists { get; set; }

        
    }
}