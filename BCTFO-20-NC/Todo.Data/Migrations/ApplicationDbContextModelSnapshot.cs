﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Todo.Data;

#nullable disable

namespace Todo.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Todo.Entities.TodoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descrtiption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descrtiption = "პირველი საქმის აღწერა...",
                            EndDate = new DateTime(2024, 4, 30, 21, 55, 31, 353, DateTimeKind.Local).AddTicks(132),
                            Priority = 2,
                            StartDate = new DateTime(2024, 4, 30, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(132),
                            Status = 1,
                            Title = "პირველი საქმე"
                        },
                        new
                        {
                            Id = 2,
                            Descrtiption = "მეორე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 4, 30, 21, 55, 31, 353, DateTimeKind.Local).AddTicks(140),
                            Priority = 1,
                            StartDate = new DateTime(2024, 4, 30, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(139),
                            Status = 1,
                            Title = "მეორე საქმე"
                        },
                        new
                        {
                            Id = 3,
                            Descrtiption = "მესამე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 1, 1, 55, 31, 353, DateTimeKind.Local).AddTicks(142),
                            Priority = 4,
                            StartDate = new DateTime(2024, 4, 30, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(141),
                            Status = 2,
                            Title = "მესამე საქმე"
                        },
                        new
                        {
                            Id = 4,
                            Descrtiption = "მეოთხე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 7, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(144),
                            Priority = 1,
                            StartDate = new DateTime(2024, 4, 30, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(144),
                            Status = 1,
                            Title = "მეოთხე საქმე"
                        },
                        new
                        {
                            Id = 5,
                            Descrtiption = "მეხუთე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 3, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(148),
                            Priority = 3,
                            StartDate = new DateTime(2024, 4, 30, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(148),
                            Status = 1,
                            Title = "მეხუთე საქმე"
                        },
                        new
                        {
                            Id = 6,
                            Descrtiption = "მეექვსე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 10, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(150),
                            Priority = 2,
                            StartDate = new DateTime(2024, 4, 30, 20, 55, 31, 353, DateTimeKind.Local).AddTicks(150),
                            Status = 2,
                            Title = "მეექვსე საქმე"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
