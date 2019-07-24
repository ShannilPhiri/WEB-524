using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignments9.Models
{
    public class TrackBase
    {
        public TrackBase()
        {
            Clerk = "n/a";
        }

        [Key]
        public int Id { get; set; }

        [StringLength(128)]
        [Display(Name = "Track Genre")]
        public string Genre { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        [Required, StringLength(200)]
        public string Clerk { get; set; }


        [Required, StringLength(200)]
        public string Composers { get; set; }


    }
}