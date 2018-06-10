using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbumsGuide.Database.Shared
{
    public class DropCreateIfDatabaseEmpty : IDatabaseInitializer<MusicAlbumsGuideDB>
    {
        public void InitializeDatabase(MusicAlbumsGuideDB context)
        {

            if (context.isDatabaseEmpty())
            {
                Seed(context);
            }
        }
        protected virtual void Seed(MusicAlbumsGuideDB context)
        {

        }
    }
}
