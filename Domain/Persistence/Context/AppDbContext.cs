using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Gappstone.API.Domain.Models;
using Gappstone.API.Extensions;

namespace Gappstone.API.Domain.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Career> Careers { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<UserCareer> UserCareers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Tutor> Tutors { get; set; }


        public DbSet<Tutorship> Tutorships { get; set; }
        public DbSet<Schedule> Schedules { get; set; }


        public DbSet<Payment> Payments { get; set; }
        public DbSet<Commission> Commissions { get; set; }
        public DbSet<Bill> Bills { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //[CAREER ENTITY]==============================================================
                    builder.Entity<Career>().ToTable("Careers");

                    //Constraints
                    builder.Entity<Career>().HasKey(c => c.CareerId);
                    builder.Entity<Career>().Property(c => c.CareerId).IsRequired().ValueGeneratedOnAdd();
                    builder.Entity<Career>().Property(c => c.CarrerName).IsRequired().HasMaxLength(50);

                    //Relationships    

                    //Seed Data
                    builder.Entity<Career>().HasData
                        (
                            new Career { CareerId = 100, CarrerName = "Ingenieria de software" },
                            new Career { CareerId = 101, CarrerName = "Ingenieria de sistemas"},
                            new Career { CareerId = 102, CarrerName = "Informatica"}
                            );


            //[UNIVERSITY ENTITY]==========================================================
                    builder.Entity<University>().ToTable("Universities");

                    //Contraints
                    builder.Entity<University>().HasKey(u => u.UniversityId);
                    builder.Entity<University>().Property(u => u.UniversityId).IsRequired().ValueGeneratedOnAdd();
                    builder.Entity<University>().Property(u => u.UniversityName).IsRequired().HasMaxLength(80);
                    builder.Entity<University>().Property(u => u.Description).HasMaxLength(300);

                    //Relationships

                    //Seed Data
                    builder.Entity<University>().HasData
                        (
                        new University { UniversityId = 100, UniversityName = "Universidad Peruana de Ciencias Aplicadas", Description = "Una universidad muy cara en Lima" },
                        new University { UniversityId = 101, UniversityName = "Universidad Privada del Norte", Description = "Una universidad no tan cara en Lima" },
                        new University { UniversityId = 102, UniversityName = "Universidad Cesar Vallejo", Description = "Una dis'q universidad en Lima" }
                        );


            //[USERCAREER ENTITY]==========================================================
                    builder.Entity<UserCareer>().ToTable("UserCareers");

                    //Contraints
                    builder.Entity<UserCareer>().HasKey(uc => uc.UserCareerId);
                    builder.Entity<UserCareer>().Property(uc => uc.UserCareerId).IsRequired().ValueGeneratedOnAdd();
                    builder.Entity<UserCareer>().Property(uc => uc.UniversityStudentCode).HasMaxLength(10);

                    //Relationships
                    builder.Entity<UserCareer>().HasOne(c => c.Career).WithMany(uc => uc.UserCareers).HasForeignKey(c => c.CareerId);
                    builder.Entity<UserCareer>().HasOne(u => u.University).WithMany(uc => uc.UserCareers).HasForeignKey(u => u.UniversityId);
                    builder.Entity<UserCareer>().HasOne(us => us.User).WithMany(uc => uc.UserCareers).HasForeignKey(us => us.UserId);

                    //Seed Data
                    builder.Entity<UserCareer>().HasData
                        (
                        new UserCareer { UserCareerId = 100, CareerId = 100, UserId = 100, UniversityId = 100, UniversityStudentCode = "u20179988" },
                        new UserCareer { UserCareerId = 101, CareerId = 102, UserId = 101, UniversityId = 101, UniversityStudentCode = "001747777" }
                        );


            //[COUNTRY ENTITY]=============================================================
                    builder.Entity<Country>().ToTable("Countries");

                    //Contraints
                    builder.Entity<Country>().HasKey(co => co.CountryId);
                    builder.Entity<Country>().Property(co => co.CountryId).IsRequired().ValueGeneratedOnAdd();
                    builder.Entity<Country>().Property(co => co.CountryName).IsRequired().HasMaxLength(30);

                    //Relationships

                    //Seed Data
                    builder.Entity<Country>().HasData
                        (
                        new Country { CountryId = 100, CountryName = "Perú" },
                        new Country { CountryId = 101, CountryName = "Argentina" },
                        new Country { CountryId = 102, CountryName = "Chile" }
                        );


            //[USER ENTITY]================================================================
                    builder.Entity<User>().ToTable("Users");

                    //Contraints
                    builder.Entity<User>().HasKey(us => us.UserId);
                    builder.Entity<User>().Property(us => us.UserId).IsRequired().ValueGeneratedOnAdd();
                    builder.Entity<User>().Property(us => us.EUserType).IsRequired();
                    builder.Entity<User>().Property(us => us.Name).IsRequired().HasMaxLength(30);
                    builder.Entity<User>().Property(us => us.TelephoneNumber);
                    builder.Entity<User>().Property(us => us.Email).IsRequired().HasMaxLength(50);
                    builder.Entity<User>().Property(us => us.Password).IsRequired().HasMaxLength(30);

                    //Relationships
                    builder.Entity<User>().HasOne(co => co.Country).WithMany(us => us.Users).HasForeignKey(co => co.CountryId);

                    //Seed Data

        }
    }
}
