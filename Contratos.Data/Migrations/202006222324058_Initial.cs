namespace Contratos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contrato",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        Tipo = c.String(nullable: false, maxLength: 50, unicode: false),
                        NomeArquivo = c.String(maxLength: 100, unicode: false),
                        Arquivo = c.Binary(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MesAno = c.DateTime(nullable: false),
                        Duracao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Login = c.String(nullable: false, maxLength: 15, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contrato", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Contrato", new[] { "ClienteId" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Contrato");
            DropTable("dbo.Cliente");
        }
    }
}
