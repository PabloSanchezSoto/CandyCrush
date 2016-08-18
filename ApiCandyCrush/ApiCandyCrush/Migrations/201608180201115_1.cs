namespace ApiCandyCrush.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        correo = c.String(),
                        usuario = c.String(),
                        contraseña = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registers");
        }
    }
}
