using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment5.EntityModels;

namespace Assignment5.Models
{
    public class TrackWithDetailViewModel : TrackBaseViewModel
    {
       

        public  MediaTypeBaseViewModel MediaType { get; set; }
        public string MediaTypeName { get; set; }
        public string AlbumTitle{ get; set; }
       
    }
}