namespace MusicAlbumsGuide.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumId = c.Int(nullable: false, identity: true),
                        ReleaseYear = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        CarrierId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        TrackCount = c.Int(nullable: false),
                        ReleasingLabelId = c.Int(nullable: false),
                        CoverPhoto = c.Binary(),
                    })
                .PrimaryKey(t => t.AlbumId)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Carriers", t => t.CarrierId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .ForeignKey("dbo.ReleasingLabels", t => t.ReleasingLabelId, cascadeDelete: true)
                .ForeignKey("dbo.Types", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.CarrierId)
                .Index(t => t.TypeId)
                .Index(t => t.GenreId)
                .Index(t => t.AuthorId)
                .Index(t => t.ReleasingLabelId);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Carriers",
                c => new
                    {
                        CarrierId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CarrierId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.ReleasingLabels",
                c => new
                    {
                        ReleasingLabelId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ReleasingLabelId);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        TypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "TypeId", "dbo.Types");
            DropForeignKey("dbo.Albums", "ReleasingLabelId", "dbo.ReleasingLabels");
            DropForeignKey("dbo.Albums", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Albums", "CarrierId", "dbo.Carriers");
            DropForeignKey("dbo.Albums", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Albums", new[] { "ReleasingLabelId" });
            DropIndex("dbo.Albums", new[] { "AuthorId" });
            DropIndex("dbo.Albums", new[] { "GenreId" });
            DropIndex("dbo.Albums", new[] { "TypeId" });
            DropIndex("dbo.Albums", new[] { "CarrierId" });
            DropTable("dbo.Types");
            DropTable("dbo.ReleasingLabels");
            DropTable("dbo.Genres");
            DropTable("dbo.Carriers");
            DropTable("dbo.Authors");
            DropTable("dbo.Albums");
        }
    }
}
