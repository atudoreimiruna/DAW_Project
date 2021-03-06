// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect1.DAL;

namespace Proiect1.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220117183110_AddedClientAddressTable")]
    partial class AddedClientAddressTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proiect1.DAL.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.ClientAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("Zipcode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("ClientAddresses");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CollectionName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NumberOfItems")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.CollectionFactory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CollectionId")
                        .HasColumnType("int");

                    b.Property<int>("Contact")
                        .HasColumnType("int");

                    b.Property<string>("FactoryAddress")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FactoryName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.ToTable("CollectionFactories");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.Designer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Designers");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.DesignerAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DesignerId")
                        .HasColumnType("int");

                    b.Property<int>("Zipcode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DesignerId")
                        .IsUnique();

                    b.ToTable("DesignerAddresses");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.DesignerAward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contest")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DesignerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("DesignerId");

                    b.ToTable("DesignerAwards");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.DesignerClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("DesignerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("DesignerId");

                    b.ToTable("DesignerClients");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.DesignerCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CollectionId")
                        .HasColumnType("int");

                    b.Property<int>("DesignerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.HasIndex("DesignerId");

                    b.ToTable("DesignerCollections");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.ClientAddress", b =>
                {
                    b.HasOne("Proiect1.DAL.Entities.Client", "Client")
                        .WithOne("ClientAddress")
                        .HasForeignKey("Proiect1.DAL.Entities.ClientAddress", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.CollectionFactory", b =>
                {
                    b.HasOne("Proiect1.DAL.Entities.Collection", "Collection")
                        .WithMany("Factories")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collection");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.DesignerAddress", b =>
                {
                    b.HasOne("Proiect1.DAL.Entities.Designer", "Designer")
                        .WithOne("DesignerAddress")
                        .HasForeignKey("Proiect1.DAL.Entities.DesignerAddress", "DesignerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Designer");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.DesignerAward", b =>
                {
                    b.HasOne("Proiect1.DAL.Entities.Designer", "Designer")
                        .WithMany("DesignerAwards")
                        .HasForeignKey("DesignerId");

                    b.Navigation("Designer");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.DesignerClient", b =>
                {
                    b.HasOne("Proiect1.DAL.Entities.Client", "Client")
                        .WithMany("DesignerClients")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect1.DAL.Entities.Designer", "Designer")
                        .WithMany("DesignerClients")
                        .HasForeignKey("DesignerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Designer");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.DesignerCollection", b =>
                {
                    b.HasOne("Proiect1.DAL.Entities.Collection", "Collection")
                        .WithMany("DesignerCollections")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect1.DAL.Entities.Designer", "Designer")
                        .WithMany("DesignerCollections")
                        .HasForeignKey("DesignerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collection");

                    b.Navigation("Designer");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.Client", b =>
                {
                    b.Navigation("ClientAddress");

                    b.Navigation("DesignerClients");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.Collection", b =>
                {
                    b.Navigation("DesignerCollections");

                    b.Navigation("Factories");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.Designer", b =>
                {
                    b.Navigation("DesignerAddress");

                    b.Navigation("DesignerAwards");

                    b.Navigation("DesignerClients");

                    b.Navigation("DesignerCollections");
                });
#pragma warning restore 612, 618
        }
    }
}
