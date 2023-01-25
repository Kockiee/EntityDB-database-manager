namespace EntityDBApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contas",
                c => new
                    {
                        IdConta = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Descricao = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.IdConta);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contas");
        }
    }
}
