// <auto-generated />
using System;
using DevBoost.DroneDelivery.Pagamento.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DevBoost.DroneDelivery.Pagamento.Infrastructure.Data.Migrations
{
    [DbContext(typeof(PagamentoContext))]
    partial class PagamentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DevBoost.DroneDelivery.Pagamento.Domain.Entites.Cartao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<short>("AnoVencimento")
                        .HasColumnType("smallint");

                    b.Property<string>("Bandeira")
                        .IsRequired()
                        .HasColumnType("Varchar(30)");

                    b.Property<short>("MesVencimento")
                        .HasColumnType("smallint");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cartao");
                });

            modelBuilder.Entity("DevBoost.DroneDelivery.Pagamento.Domain.Entites.PagamentoCartao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CartaoId")
                        .IsUnique();

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("DevBoost.DroneDelivery.Pagamento.Domain.Entites.PagamentoCartao", b =>
                {
                    b.HasOne("DevBoost.DroneDelivery.Pagamento.Domain.Entites.Cartao", "Cartao")
                        .WithOne("PagamentoCartao")
                        .HasForeignKey("DevBoost.DroneDelivery.Pagamento.Domain.Entites.PagamentoCartao", "CartaoId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
