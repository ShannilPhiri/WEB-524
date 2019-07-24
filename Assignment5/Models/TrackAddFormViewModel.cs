using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Models
{
    public class TrackAddFormViewModel : TrackAddViewModel
    {


        [Display(Name = "Album")]
        public SelectList AlbumList { get; set; }

        //[Display(Name = "Album")]
        public string AlbumTitle { get; set; }


        [Display(Name = "Media Type")]
        public SelectList MediaTypeList { get; set; }

        //[Display(Name = "Media Type")]
        public string MediaTypeName { get; set; }






    }
}