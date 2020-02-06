namespace Lifesys.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FkEmpresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fornecedor", "EmpresaId", c => c.Long(nullable: false));
            CreateIndex("dbo.Fornecedor", "EmpresaId");
            AddForeignKey("dbo.Fornecedor", "EmpresaId", "dbo.Empresa", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fornecedor", "EmpresaId", "dbo.Empresa");
            DropIndex("dbo.Fornecedor", new[] { "EmpresaId" });
            DropColumn("dbo.Fornecedor", "EmpresaId");
        }
    }
}
