// <auto-generated />
using System;
using CodaxyProject.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodaxyProject.Migrations
{
    [DbContext(typeof(CodaxyDBContext))]
    [Migration("20211010171037_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodaxyProject.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeUpdated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Dejan Bunic",
                            Status = 0,
                            TimeCreated = new DateTime(2021, 10, 10, 19, 10, 36, 858, DateTimeKind.Local).AddTicks(5096),
                            TimeUpdated = new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(2718)
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Pero Peric",
                            Status = 2,
                            TimeCreated = new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(3551),
                            TimeUpdated = new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(3573)
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Pero Budak",
                            Status = 1,
                            TimeCreated = new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(3591),
                            TimeUpdated = new DateTime(2021, 10, 10, 19, 10, 36, 861, DateTimeKind.Local).AddTicks(3595)
                        });
                });

            modelBuilder.Entity("CodaxyProject.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeUpdated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("CartItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CartId = 1,
                            CreatedBy = "Dejan Bunic",
                            Description = "hibridni kukuruz",
                            Name = "kukuruz",
                            TimeCreated = new DateTime(2021, 10, 10, 19, 10, 36, 862, DateTimeKind.Local).AddTicks(9192),
                            TimeUpdated = new DateTime(2021, 10, 10, 19, 10, 36, 862, DateTimeKind.Local).AddTicks(9532)
                        },
                        new
                        {
                            Id = 2,
                            CartId = 1,
                            CreatedBy = "Dejan Bunic",
                            Description = "crveni",
                            Name = "krompir",
                            TimeCreated = new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(148),
                            TimeUpdated = new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(178)
                        },
                        new
                        {
                            Id = 3,
                            CartId = 2,
                            CreatedBy = "Pero Peric",
                            Description = "crveni",
                            Name = "krompir",
                            TimeCreated = new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(195),
                            TimeUpdated = new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(199)
                        },
                        new
                        {
                            Id = 4,
                            CartId = 2,
                            CreatedBy = "Pero Peric",
                            Description = "ljuta paprika",
                            Name = "cips",
                            TimeCreated = new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(203),
                            TimeUpdated = new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(207)
                        },
                        new
                        {
                            Id = 5,
                            CartId = 3,
                            CreatedBy = "Pero Budak",
                            Description = "slane przene",
                            Name = "sjemenke bundeve",
                            TimeCreated = new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(211),
                            TimeUpdated = new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(214)
                        },
                        new
                        {
                            Id = 6,
                            CartId = 3,
                            CreatedBy = "Pero Budak",
                            Description = "zaledjeni fileti",
                            Name = "oslic",
                            TimeCreated = new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(218),
                            TimeUpdated = new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(221)
                        },
                        new
                        {
                            Id = 7,
                            CartId = 3,
                            CreatedBy = "Pero Budak",
                            Description = "sa ljesnjakom",
                            Name = "cokolada",
                            TimeCreated = new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(225),
                            TimeUpdated = new DateTime(2021, 10, 10, 19, 10, 36, 863, DateTimeKind.Local).AddTicks(228)
                        });
                });

            modelBuilder.Entity("CodaxyProject.Models.CartItem", b =>
                {
                    b.HasOne("CodaxyProject.Models.Cart", null)
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodaxyProject.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
