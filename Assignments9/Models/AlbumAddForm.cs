using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignments9.Models
{
    public class AlbumAddForm : AlbumBase
    {
        [StringLength(200)]
        public SelectList GenreList { get; set; }

        public MultiSelectList ArtistList { get; set; }


        public MultiSelectList TrackList { get; set; }
    }
}