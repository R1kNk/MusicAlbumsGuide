using MusicAlbumsGuide.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbumsGuide.Database.Shared
{
    static public class SharedContextMethods
    {

        static public bool isDatabaseEmpty(this MusicAlbumsGuideDB context)
        {
            if (!context.Database.Exists()) { context.Database.Create(); return true; }
            if (isAlbumsTableEmpty(context) && isCarriersTableEmpty(context) && isGenresTableEmpty(context) && isTypesTableEmpty(context) && isAuthorsTableEmpty(context))
                return true;
            return false;
        }

        static public bool isAlbumsTableEmpty(MusicAlbumsGuideDB context)
        {
            if (!context.Database.Exists()) { context.Database.Create(); return true; }
            if (context.Albums.ToList().Count == 0) return true;
            return false;
        }

        static public bool isCarriersTableEmpty(MusicAlbumsGuideDB context)
        {
            if (!context.Database.Exists()) { context.Database.Create(); return true; }
            if (context.Carriers.ToList().Count == 0) return true;
            return false;
        }

        static public bool isGenresTableEmpty(MusicAlbumsGuideDB context)
        {
            if (!context.Database.Exists()) { context.Database.Create(); return true; }
            if (context.Genres.ToList().Count == 0) return true;
            return false;
        }

        static public bool isTypesTableEmpty(MusicAlbumsGuideDB context)
        {
            if (!context.Database.Exists()) { context.Database.Create(); return true; }
            if (context.Types.ToList().Count == 0) return true;
            return false;
        }

        static public bool isAuthorsTableEmpty(MusicAlbumsGuideDB context)
        {
            if (!context.Database.Exists()) { context.Database.Create(); return true; }
            if (context.Authors.ToList().Count == 0) return true;
            return false;
        }

        static public Album GetFullAlbum(int AlbumId)
        {
            MusicAlbumsGuideDB context = new MusicAlbumsGuideDB();
            return context.Albums.Include(p=>p.Author).Include(p => p.Carrier).Include(p => p.Genre).Include(p => p.ReleasingLabel).Include(p => p.Type).Where(p=>p.AlbumId==AlbumId).Single();

        }

    }
}
