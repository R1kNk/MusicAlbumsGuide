using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbumsGuide.Database.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public int ReleaseYear { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey("Carrier")]
        public int CarrierId { get; set; }
        public Carrier Carrier { get; set; }

        [ForeignKey("Type")]
        public int TypeId { get; set; }
        public Type Type { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        [Required]
        public int TrackCount { get; set; }

        [ForeignKey("ReleasingLabel")]
        public int ReleasingLabelId { get; set; }
        public ReleasingLabel ReleasingLabel { get; set; }

        public byte[] CoverPhoto { get; set; }
        
    }
}
