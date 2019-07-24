using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Assignment6.Models
{
    public class PlayListWithDetails : PlayListBaseViewModel
    {
        [DisplayName("Tracks in Playlist")]
        public ICollection<TrackBaseViewModel> Tracks { get; set; }
    }
}