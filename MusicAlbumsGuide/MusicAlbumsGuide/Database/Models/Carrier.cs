using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbumsGuide.Database.Models
{
    public class Carrier
    {
        [Key]
        public int CarrierId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual List<Album> Albums { get; set; }


    }
}
