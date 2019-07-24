using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment6.Models
{
    public class PlayListEditTrackFormViewModel 
    {
        public PlayListEditTrackFormViewModel()
{
       Tracks = new List<TrackBaseViewModel>();
}
        [Key]
        public int PlaylistId { get; set; }

        [Required]
        [StringLength(120)]
        public string Name { get; set; }

        public  MultiSelectList TrackList { get; set; }
        public IEnumerable<TrackBaseViewModel> Tracks { get; set; }
        public int TracksCount { get; set; }
        public IEnumerable<TrackBaseViewModel> TracksOnPlaylist { get; set; }
    }
}