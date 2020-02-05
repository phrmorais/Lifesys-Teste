namespace Lifesys.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FkEmpresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fornecedor", "Empresa_Id", c => c.Long());
            CreateIndex("dbo.Fornecedor", "Empresa_Id");
            AddForeignKey("dbo.Fornecedor", "Empresa_Id", "dbo.Empresa", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fornecedor", "Empresa_Id", "dbo.Empresa");
            DropIndex("dbo.Fornecedor", new[] { "Empresa_Id" });
            DropColumn("dbo.Fornecedor", "Empresa_Id");
        }
    }
}
