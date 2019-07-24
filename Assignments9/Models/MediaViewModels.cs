using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignments9.Models
{
    public class MediaViewModels
    {

        public class MediaAdd
        {
            [Required]
            public int ArtistId { get; set; }

            [Required]
            public string Caption { get; set; }

            [Required]
            public HttpPostedFileBase UploadFile { get; set; }
        }

        public class MediaAddForm
        {
            [Required]
            public int Artist_Id { get; set; }

            public string ArtistName { get; set; }

            [Required]
            [Display(Name = "Descriptive caption")]
            public string Caption { get; set; }

            [Required]
            public string UploadFile { get; set; }
        }

        public class MediaBase
        {
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            public string ContentType { get; set; }

            [Required]
            public byte[] Content { get; set; }
        }

        public class MediaDetails : MediaBase
        {
            [StringLength(100)]
            public string Caltagory { get; set; }

            [Required]
            public string Caption { get; set; }
        }

        public class MediaIcon
        {
            public int Id { get; set; }

            [StringLength(100)]
            public string ContentType { get; set; }

            [Display(Name = "Descriptive caption")]
            public string Caption { get; set; }

            public string IconURL { get; set; }
        }
    }
}