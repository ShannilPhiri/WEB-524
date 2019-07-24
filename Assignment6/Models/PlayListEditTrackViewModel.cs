using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment6.Models
{
    public class PlayListEditTrackViewModel
    {
        public PlayListEditTrackViewModel()
        {
            TrackId = new List<int>();

        }

       public int Id { get; set; }

        public IEnumerable<int> TrackId { get; set; }
    }
}