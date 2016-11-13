//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data.Entity;
//using p1.Models;

//namespace p1.DAL
//{
//    public class SongInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SongContext>
//    {
//        protected override void Seed(SongContext context)
//        {
//            var songs = new List<Song>
//            {
//                new Song {ID=1, Title="songone", Artist="artistA", Album="albumAone", Length=3.33m, Genre="genreold" },
//                new Song {ID=1, Title="songtwo", Artist="artistA", Album="albumAone", Length=4.44m, Genre="genreold" },
//                new Song {ID=1, Title="songfive", Artist="artistC", Album="albumGthree", Length=5.55m, Genre="genreold" }
//            };

//            songs.ForEach(s => context.Songs.Add(s));
//            context.SaveChanges();

//            /*
//            For each entity type, the code creates a collection of new entities, adds them to the appropriate DbSet property, and then saves the
//            changes to the database
//            */

//            //base.Seed(context);
//        }
//        /*
//        seed method takes the database context object as an input parameter and the code in the method uses that object to add new entities to the database        
//        */
//    }
//}