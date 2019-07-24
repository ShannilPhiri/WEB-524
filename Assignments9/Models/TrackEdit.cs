using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignments9.Models
{
    public class TrackEdit : TrackBase
    {
        [Required]
        [DataType(DataType.Upload)]
        public HttpPostedFileBase SampleAudio { get; set; }
    }
}