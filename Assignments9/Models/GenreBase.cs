using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignments9.Models
{
    public class GenreBase
    {
        [Key]
        public int id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }
    }
}