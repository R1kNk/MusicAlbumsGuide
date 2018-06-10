using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbumsGuide.Database.Models
{
    public class Type
    {
        public int TypeId { get; set; }
        public string Name { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}
