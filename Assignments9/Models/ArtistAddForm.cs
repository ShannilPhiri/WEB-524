using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignments9.Models
{
    public class ArtistAddForm : ArtistBase
    {
        [StringLength(200)]
        public SelectList GenreList { get; set; }
        
    }
}