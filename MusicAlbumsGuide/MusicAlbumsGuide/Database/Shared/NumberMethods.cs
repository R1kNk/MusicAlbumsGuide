using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbumsGuide.Database.Shared
{
    static class NumberMethods
    {
        public static float PixelsToPdfCoords( int pixels)
        {
            return (float)(pixels / 1.331666666666667);
        }
    }
}
