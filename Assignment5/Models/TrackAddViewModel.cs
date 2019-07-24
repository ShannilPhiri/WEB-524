using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Models
{
    public class TrackAddViewModel 
    {

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(220)]
        public string Composer { get; set; }

        [Required]
        public int Milliseconds { get; set; }

        [Required]
        [Column(TypeName = "numeric")]
        public decimal UnitPrice { get; set; }

        [Range(1, Int32.MaxValue)]
        public int AlbumId { get; set; }

        public int TrackId { get; set; }
        
        [Range(1, Int32.MaxValue)]
        public int MediaTypeId { get; set; }

       

   

      

        


    }
}