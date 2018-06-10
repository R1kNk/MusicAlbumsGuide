namespace MusicAlbumsGuide.Database
{
    using MusicAlbumsGuide.Database.Models;
    using MusicAlbumsGuide.Database.Shared;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MusicAlbumsGuideDB : DbContext
    {
        // Your context has been configured to use a 'MusicAlbumsGuideDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MusicAlbumsGuide.Database.MusicAlbumsGuideDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MusicAlbumsGuideDB' 
        // connection string in the application configuration file.
        public MusicAlbumsGuideDB()
            : base("name=MusicAlbumsGuideDB")
        {
            System.Data.Entity.Database.SetInitializer(new MusicAlbumsGuideInitializer());
            

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Carrier> Carriers { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Models.Type> Types { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<ReleasingLabel> ReleasingLabels { get; set; }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}