using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignments9.Models
{
    public class TrackAdd : TrackBase
    {
        public TrackAdd()
        {
            AlbumIds = new List<int>();
        }

        public IEnumerable<int> AlbumIds;
        [DataType(DataType.Upload)]
        public HttpPostedFileBase SampleAudio { get; set; }

    }
}