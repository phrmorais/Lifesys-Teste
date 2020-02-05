namespace Lifesys.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CargaInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Uf = c.Int(nullable: false),
                        NomeFantasia = c.String(),
                        Cnpj = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        Documento_NumDoc = c.String(),
                        Documento_TipoInscricao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fornecedor");
            DropTable("dbo.Empresa");
        }
    }
}
