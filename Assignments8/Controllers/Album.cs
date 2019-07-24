using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignments8.Controllers
{
    public class Album
    {
        [Required]
        [StringLength(128)]
        [Display(Name = "Album Name")]
        public string Name { get; set; }

        [StringLength(128)]
        [Display(Name = "Coordinator Who Looks After the Album")]
        public string Coordinator { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Album Image (Cover Art)")]
        public string UrlAlbum { get; set; }

        public Album()
        {
            ReleaseDate = DateTime.Now;
        }
    }

    public class AlbumFormView : Album
    {
        [Display(Name = "Album's Primary Genre")]
        public SelectList Genre { get; set; }

        [Display(Name = "All Artists")]
        public MultiSelectList Artists { get; set; }

        [Display(Name = "All Tracks")]
        public MultiSelectList Tracks { get; set; }

    }

    public class AlbumAdd : Album
    {
        public string Genre { get; set; }

        public IEnumerable<int> ArtistIds { get; set; }

        public IEnumerable<int> TrackIds { get; set; }
    }

    public class AlbumBase : Album
    {
        [Key]
        public int Id { get; set; }

        [StringLength(128)]
        [Display(Name = "Album's Primary Genre")]
        public string Genre { get; set; }

    }

    public class AlbumDetail : AlbumBase
    {
        [Display(Name = "Album's Artists")]
        public IEnumerable<ArtistBase> Artists { get; set; }

        [Display(Name = "Album's Tracks")]
        public IEnumerable<TrackBase> Tracks { get; set; }

        public AlbumDetail()
        {
            Artists = new List<ArtistBase>();
            Tracks = new List<TrackBase>();
        }
    }
}
