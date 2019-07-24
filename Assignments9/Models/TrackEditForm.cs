using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignments9.Models
{
    public class TrackEditForm : TrackBase
    {
    [Required]
    [Display(Name = "Sample Clip")]
    [DataType(DataType.Upload)]
    public string SampleAudio { get; set; }
}
}