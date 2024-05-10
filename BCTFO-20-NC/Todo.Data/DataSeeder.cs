using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Todo.Entities;

namespace Todo.Data
{
    public static class DataSeeder
    {
        public static void SeedTodos(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoEntity>().HasData(
                    new TodoEntity
                    {
                        Id = 1,
                        Title = "პირველი საქმე",
                        Descrtiption = "პირველი საქმის აღწერა...",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddHours(1),
                        Status = Status.Todo,
                        Priority = Priority.Medium,
                        UserId = "D514EDC9-94BB-416F-AF9D-7C13669689C9"
                    },
                    new TodoEntity
                    {
                        Id = 2,
                        Title = "მეორე საქმე",
                        Descrtiption = "მეორე საქმის აღწერა...",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddHours(1),
                        Status = Status.Todo,
                        Priority = Priority.Low,
                        UserId = "D514EDC9-94BB-416F-AF9D-7C13669689C9"
                    },
                    new TodoEntity
                    {
                        Id = 3,
                        Title = "მესამე საქმე",
                        Descrtiption = "მესამე საქმის აღწერა...",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddHours(5),
                        Status = Status.Doing,
                        Priority = Priority.Urgent,
                        UserId = "D514EDC9-94BB-416F-AF9D-7C13669689C9"
                    },
                    new TodoEntity
                    {
                        Id = 4,
                        Title = "მეოთხე საქმე",
                        Descrtiption = "მეოთხე საქმის აღწერა...",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(7),
                        Status = Status.Todo,
                        Priority = Priority.Low,
                        UserId = "87746F88-DC38-4756-924A-B95CFF3A1D8A"
                    },
                    new TodoEntity
                    {
                        Id = 5,
                        Title = "მეხუთე საქმე",
                        Descrtiption = "მეხუთე საქმის აღწერა...",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(3),
                        Status = Status.Todo,
                        Priority = Priority.High,
                        UserId = "87746F88-DC38-4756-924A-B95CFF3A1D8A"
                    },
                    new TodoEntity
                    {
                        Id = 6,
                        Title = "მეექვსე საქმე",
                        Descrtiption = "მეექვსე საქმის აღწერა...",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(10),
                        Status = Status.Doing,
                        Priority = Priority.Medium,
                        UserId = "87746F88-DC38-4756-924A-B95CFF3A1D8A"
                    }
                );
        }

        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "33B7ED72-9434-434A-82D4-3018B018CB87", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", Name = "Customer", NormalizedName = "CUSTOMER" }
            );

        }

        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            PasswordHasher<IdentityUser> hasher = new();

            modelBuilder.Entity<IdentityUser>().HasData(
                    new IdentityUser()
                    {
                        Id = "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                        UserName = "admin@gmail.com",
                        NormalizedUserName = "ADMIN@GMAIL.COM",
                        Email = "admin@gmail.com",
                        NormalizedEmail = "ADMIN@GMAIL.COM",
                        EmailConfirmed = false,
                        PasswordHash = hasher.HashPassword(null, "Admin123!"),
                        PhoneNumber = "555337681",
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnd = null,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new IdentityUser()
                    {
                        Id = "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                        UserName = "nika@gmail.com",
                        NormalizedUserName = "NIKA@GMAIL.COM",
                        Email = "nika@gmail.com",
                        NormalizedEmail = "NIKA@GMAIL.COM",
                        EmailConfirmed = false,
                        PasswordHash = hasher.HashPassword(null, "Nika123!"),
                        PhoneNumber = "558490645",
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnd = null,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new IdentityUser()
                    {
                        Id = "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                        UserName = "gio@gmail.com",
                        NormalizedUserName = "GIO@GMAIL.COM",
                        Email = "gio@gmail.com",
                        NormalizedEmail = "GIO@GMAIL.COM",
                        EmailConfirmed = false,
                        PasswordHash = hasher.HashPassword(null, "Gio123!"),
                        PhoneNumber = "551442269",
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnd = null,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    }
                );
        }


        public static void SeedUserRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = "33B7ED72-9434-434A-82D4-3018B018CB87", UserId = "8716071C-1D9B-48FD-B3D0-F059C4FB8031" },
                new IdentityUserRole<string> { RoleId = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", UserId = "D514EDC9-94BB-416F-AF9D-7C13669689C9" },
                new IdentityUserRole<string> { RoleId = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", UserId = "87746F88-DC38-4756-924A-B95CFF3A1D8A" }
            );
        }


    }
}
