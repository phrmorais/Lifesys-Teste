using Lifesys.Domain.Entity;
using Lifesys.Domain.ObjectValues;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Lifesys.Infrastructure.Context
{
    public class LifesysContext : DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public LifesysContext() : base("LifesysDB")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {



            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.ComplexType<Documento>();
            modelBuilder.ComplexType<Documento>().Property(a => a.NumDoc);
            modelBuilder.ComplexType<Documento>().Property(a => a.TipoInscricao);

            //This line lets everything work but doesn't include my 
            //AuditInformation attributes in my User Table.
            //mb.Ignore<Domain.Model.AuditInformation>(); // <== I think I need to remove this

            ////..

            //mb.Entity<User>().Map(a => {
            //    a.Property(x => x.Id).HasColumnName("Id");
            //    a.Property(x => x.UserId).HasColumnName("User_Id");
            //    a.Property(x => x.Domain).HasColumnName("User_Dmain");
            //})
            //.HasKey(x => x.Id)
            //.ToTable("Tbl_User");
            //modelBuilder.Configurations.Add(new FornecedorConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
