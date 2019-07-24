using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignments9.Models
{
    public class TrackAddForm : TrackBase
    {
        public MultiSelectList AlbumList { get; set; }

        public SelectList GenreList { get; set; }
        [Display(Name = "Sample Clip")]
        [DataType(DataType.Upload)]
        public string SampleAudio { get; set; }
    }
}