namespace Lifesys.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Documento_Numero : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fornecedor", "Documento_Numero", c => c.String());
            DropColumn("dbo.Fornecedor", "Documento_NumDoc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fornecedor", "Documento_NumDoc", c => c.String());
            DropColumn("dbo.Fornecedor", "Documento_Numero");
        }
    }
}
