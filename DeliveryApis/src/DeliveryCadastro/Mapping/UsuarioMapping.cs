using DeliveryCadastro.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeliveryCadastro.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            
            
            builder.HasKey(x => x.Id);

            builder.Property(x =>x.Id)
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd(); 

            builder.Property(x => x.Senha)
                .IsRequired()
                .HasColumnName("SENHA")
                .HasColumnType("varchar(15)");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnName("EMAIL")
                .HasColumnType("varchar(30)");

            builder.Property(x => x.Telefone)
               .IsRequired()
               .HasColumnName("TELEFONE")
               .HasColumnType("varchar(15)");

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("NOME")
                .HasColumnType("varchar(100)");

            builder.OwnsOne(x => x.Endereco, xm =>
             {
                 xm.ToTable("ENDERECO_USUARIO");

                 xm.Property(x => x.Uf)
                 .HasColumnName("UF")
                 .HasColumnType("varchar(2)");

                 xm.Property(x => x.Bairro)
                 .HasColumnName("BAIRRO")
                 .HasColumnType("varchar(100)");

                 xm.Property(x => x.Cep)
                 .HasColumnName("CEP")
                 .HasColumnType("varchar(9)");

                 xm.Property(x => x.Complemento)
                 .HasColumnName("COMPLEMENTO")
                 .HasColumnType("varchar(100)");

                 xm.Property(x => x.Municipio)
                 .HasColumnName("MUNICIPIO")
                 .HasColumnType("varchar(100)");

                 xm.Property(x => x.Numero)
                 .HasColumnName("NUMERO")
                 .HasColumnType("int"); ;

                 xm.Property(x => x.Rua)
                 .HasColumnName("RUA")
                 .HasColumnType("varchar(150)"); ;

             });

            builder.ToTable("USUARIOS");
        }
    }
}
