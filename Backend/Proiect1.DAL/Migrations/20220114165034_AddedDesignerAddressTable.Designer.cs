﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect1.DAL;

namespace Proiect1.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220114165034_AddedDesignerAddressTable")]
    partial class AddedDesignerAddressTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("Proiect1.DAL.Entities.DesignerAddress", b =>
                {
                    b.HasOne("Proiect1.DAL.Entities.Designer", "Designer")
                        .WithOne("DesignerAddress")
                        .HasForeignKey("Proiect1.DAL.Entities.DesignerAddress", "DesignerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Designer");
                });

            modelBuilder.Entity("Proiect1.DAL.Entities.Designer", b =>
                {
                    b.Navigation("DesignerAddress");
                });
#pragma warning restore 612, 618
        }
    }
}