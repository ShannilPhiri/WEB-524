using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace Assignments8.Controllers
{
    public class Track
    {
            [Required]
            [StringLength(128)]
            [Display(Name = "Track Name")]
            public string Name { get; set; }

            [StringLength(128)]
            [Display(Name = "Clerk Who Help with")]
            public string Clerk { get; set; }

            [StringLength(128)]
            [Display(Name = "Composer Name(s)")]
            public string Composers { get; set; }

        }

        public class TrackForm : Track
        {
            [Display(Name = "All Genre")]
            public SelectList GenreSelect { get; set; }

            [Display(Name = "All Albums")]
            public MultiSelectList AlbumsSelect { get; set; }
        }

        public class TrackAdd : Track
        {
            [StringLength(128)]
            public string Genre { get; set; }

            public IEnumerable<int> AlbumIds { get; set; }
        }

        public class TrackEdit : TrackAdd
        {
            [Key]
            public int Id { get; set; }
        }

        public class TrackBase : Track
        {
            [Key]
            public int Id { get; set; }

            [StringLength(128)]
            [Display(Name = "Track Genre")]
            public string Genre { get; set; }

        }

        public class TrackDetail : TrackBase
        {
            [Display(Name = "Number of Albums with this Track")]
            public IEnumerable<AlbumBase> Albums { get; set; }

            public TrackDetail()
            {
                Albums = new List<AlbumBase>();
            }
        }
    }
