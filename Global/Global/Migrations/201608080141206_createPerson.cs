namespace Global.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createPerson : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        edad = c.Int(nullable: false),
                        telefono = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personas");
        }
    }
}
