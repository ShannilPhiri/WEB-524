using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignments9.Models
{
    public class TrackWithDetail: TrackBase
    {
        public TrackWithDetail()
        {
            Albums = new List<AlbumBase>();
        }
        public IEnumerable<string> AlbumNames { get; internal set; }
        public IEnumerable<AlbumBase> Albums { get; set; }
        public string ContentType { get; set; }
    }
}