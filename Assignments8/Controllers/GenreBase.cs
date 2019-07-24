using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignments8.Controllers
{
    public class GenreBase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }
    }
}