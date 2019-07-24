using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class TrackBaseViewModel

    {
        public TrackBaseViewModel()
        {

        }
        [Key]
        public int TrackId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(220)]
        public string Composer { get; set; }

        [Display(Name ="Length(ms)")]
       public int Milliseconds { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UnitPrice { get; set; }

        
    }
}
