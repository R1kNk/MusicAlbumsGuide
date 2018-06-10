using MusicAlbumsGuide.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAlbumsGuide.Database.Shared
{

    public class MusicAlbumsGuideInitializer : DropCreateIfDatabaseEmpty
    {
        protected override void Seed(MusicAlbumsGuideDB context)
        {
            //List<Lot> lots = new List<Lot>() { new Lot { Name = "Мультиварка Bosch", State = "б/у", StartDate = DateTime.Now, FinishDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 2) } };
            //for (int i = 0; i < lots.Count; i++)
            //{
            //    context.Lots.Add(lots[i]);
            //}
            //context.SaveChanges();
            List<Carrier> carriers = new List<Carrier>()
            {
                new Carrier(){Name="Винил"},
                new Carrier(){Name="Аудиокассеты"},
                new Carrier(){Name="Цифровой носитель"},
                new Carrier(){Name="CD диск"}
            };
            for (int i = 0; i < carriers.Count; i++)
                context.Carriers.Add(carriers[i]);
            context.SaveChanges();

            List<Genre> genres = new List<Genre>()
            {
                new Genre(){Name="oldschool rap"},
                new Genre(){Name="newschool rap"},
                new Genre(){Name="gangsta rap"},
                new Genre(){Name="horrorcore"},
                new Genre(){Name="south hip-hop"},
                new Genre(){Name="rock"},
                new Genre(){Name="punk-rock"},
                new Genre(){Name="hardcore"},
                new Genre(){Name="post-hardcore"},
                new Genre(){Name="metalcore"},
                new Genre(){Name="emo"},
                new Genre(){Name="screamo"},
                new Genre(){Name="punk"},
                new Genre(){Name="post-punk"},
                new Genre(){Name="metal"},
                new Genre(){Name="nu-metal"},
                new Genre(){Name="heavy metal"},
                new Genre(){Name="trash metal"},
                new Genre(){Name="black metal"},
                new Genre(){Name="death metal"},
                new Genre(){Name="slamming brutal death"},
                new Genre(){Name="funeral doom"},
                new Genre(){Name="doom metal"},
                new Genre(){Name="EDM"},
                new Genre(){Name="techno"},
                new Genre(){Name="house"},
                new Genre(){Name="tranсe"},
                new Genre(){Name="synthpop"},
                new Genre(){Name="ambient"},
                new Genre(){Name="noise"},
                new Genre(){Name="noise-rock"},
                new Genre(){Name="powernoise"},
                new Genre(){Name="harsh noise"},
                new Genre(){Name="classic"},
                new Genre(){Name="jazz"},
                new Genre(){Name="blues"},

            };
            for (int i = 0; i < genres.Count; i++)
                context.Genres.Add(genres[i]);
            context.SaveChanges();

            List<Models.Type> types = new List<Models.Type>()
            {
                new Models.Type(){Name="Полноформатный"},
                new Models.Type(){Name="EP"},
                new Models.Type(){Name="Сингл"},
                 new Models.Type(){Name="Демо"},
                new Models.Type(){Name="Сплит"}
            };
            for (int i = 0; i < types.Count; i++)
                context.Types.Add(types[i]);
            context.SaveChanges();

            context.SaveChanges();
        }
    }
    
   
}
