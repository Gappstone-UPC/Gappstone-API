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
                        new Career { CareerId = 101, CarrerName = "Ingenieria de sistemas" },
                        new Career { CareerId = 102, CarrerName = "Informatica" }
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
                builder.Entity<User>().HasData(
                    new User { UserId = 100, EUserType = EUserType.Student, Name = "Juan Lopez", TelephoneNumber = 5236878, Email = "Juan.Lopez@hotmail.com", Password = "123456", CountryId = 100 },
                    new User { UserId = 101, EUserType = EUserType.Student, Name = "Miguel Sanchez", TelephoneNumber = 52147321, Email = "Miguel.Sanchez@yahoo.com", Password = "123456", CountryId = 100 },
                    new User { UserId = 102, EUserType = EUserType.Tutor, Name = "Rosa Meltroso", TelephoneNumber = 5987216, Email = "Rosa.Meltroso@gmail.com", Password = "123456", CountryId = 101 }
                    );


            //[STUDENT ENTITY]=============================================================
                builder.Entity<Student>().ToTable("Students");

                //Contraints
                //builder.Entity<Student>().HasKey(st => st.StudentId);
                builder.Entity<Student>().Property(st => st.StudentId).IsRequired().ValueGeneratedOnAdd();

                //Relationships
                builder.Entity<Student>().HasOne(st => st.User).WithOne(us => us.Student).HasForeignKey<Student>(st => st.UserId);

                //Seed Data
                builder.Entity<Student>().HasData(
                    new Student { StudentId = 100, UserId = 100 },
                    new Student { StudentId = 101, UserId = 101 }
                    );


            //[TUTOR ENTITY]===============================================================
                builder.Entity<Tutor>().ToTable("Tutors");

                //Contraints
                builder.Entity<Tutor>().Property(tt => tt.Description).HasMaxLength(500);
                builder.Entity<Tutor>().Property(tt => tt.Raiting).IsRequired();
                builder.Entity<Tutor>().Property(tt => tt.EStatus).IsRequired();
                builder.Entity<Tutor>().Property(tt => tt.PricePerHour).IsRequired();

                //Relationships
                builder.Entity<Tutor>().HasOne(tt => tt.User).WithOne(us => us.Tutor).HasForeignKey<Tutor>(tt => tt.UserId);

                //Seed Data
                builder.Entity<Tutor>().HasData(
                    new Tutor { TutorId = 100, UserId = 102, Description = "Soy una tutora", Raiting = 10, EStatus = EStatus.Active, PricePerHour = 30 }
                    );


            //[SCHEDULE ENTITY]============================================================
                builder.Entity<Schedule>().ToTable("Schedules");

                //Constraints
                builder.Entity<Schedule>().HasKey(sc => sc.ScheludeId);
                builder.Entity<Schedule>().Property(sc => sc.ScheludeId).IsRequired().ValueGeneratedOnAdd();

                //Relationships
                builder.Entity<Schedule>().HasOne(sc => sc.Tutor).WithOne(tt => tt.Schedule).HasForeignKey<Schedule>(sc => sc.TutorId);

                //Seed Data
                builder.Entity<Schedule>().HasData(
                    new Schedule { ScheludeId = 100, TutorId = 100 }
                    );


            //[TUTORSHIP ENTITY]===========================================================
                builder.Entity<Tutorship>().ToTable("Tutorships");

                //Contraints
                builder.Entity<Tutorship>().HasKey(ts => ts.TutorshipId);
                builder.Entity<Tutorship>().Property(ts => ts.TutorshipId).IsRequired().ValueGeneratedOnAdd();
                builder.Entity<Tutorship>().Property(ts => ts.Theme).IsRequired().HasMaxLength(50);
                builder.Entity<Tutorship>().Property(ts => ts.Description).HasMaxLength(300);
                builder.Entity<Tutorship>().Property(ts => ts.Date).IsRequired();
                builder.Entity<Tutorship>().Property(ts => ts.Duration).IsRequired();
                builder.Entity<Tutorship>().Property(ts => ts.Cost).IsRequired();

                //Relationships
                builder.Entity<Tutorship>().HasOne(ts => ts.Student).WithMany(st => st.Tutorships).HasForeignKey(ts => ts.StudentId);
                builder.Entity<Tutorship>().HasOne(ts => ts.Tutor).WithMany(tt => tt.Tutorships).HasForeignKey(ts => ts.TutorId);
                builder.Entity<Tutorship>().HasOne(ts => ts.Schedule).WithMany(sc => sc.Tutorships).HasForeignKey(ts => ts.ScheduleId);
                builder.Entity<Tutorship>().HasOne(ts => ts.Commission).WithOne(cm => cm.Tutorship).HasForeignKey<Tutorship>(ts => ts.CommissionId);


            //[COMMISSION ENTITY]==========================================================
                builder.Entity<Commission>().ToTable("Commissions");

                //Contraints
                builder.Entity<Commission>().HasKey(cm => cm.CommissionId);
                builder.Entity<Commission>().Property(cm => cm.CommissionId).IsRequired().ValueGeneratedOnAdd();
                builder.Entity<Commission>().Property(cm => cm.Amount).IsRequired();

                //Relationships
                builder.Entity<Commission>().HasOne(cm => cm.Bill).WithMany(bl => bl.Commissions).HasForeignKey(cm => cm.BillId);
                builder.Entity<Commission>().HasOne(cm => cm.Tutorship).WithOne(ts => ts.Commission).HasForeignKey<Commission>(cm => cm.TutorshipId);


            //[PAYMENT ENTITY]=============================================================
                builder.Entity<Payment>().ToTable("Payments");

                //Contraints
                builder.Entity<Payment>().HasKey(py => py.PaymentId);
                builder.Entity<Payment>().Property(py => py.PaymentId).IsRequired().ValueGeneratedOnAdd();
                builder.Entity<Payment>().Property(py => py.PaymentCode).IsRequired().HasMaxLength(25);
                builder.Entity<Payment>().Property(py => py.ImageUrl).IsRequired().HasMaxLength(300);

                //Relationships
                builder.Entity<Payment>().HasOne(py => py.Bill).WithOne(bl => bl.Payment).HasForeignKey<Payment>(py => py.BillId);
                builder.Entity<Payment>().HasOne(py => py.Tutor).WithMany(tt => tt.Payments).HasForeignKey(py => py.TutorId);


            //[BILL ENTITY]================================================================
                builder.Entity<Bill>().ToTable("Bills");

                //Contraints
                builder.Entity<Bill>().HasKey(bl => bl.BillId);
                builder.Entity<Bill>().Property(bl => bl.BillId).IsRequired().ValueGeneratedOnAdd();
                builder.Entity<Bill>().Property(bl => bl.Date).IsRequired();
                builder.Entity<Bill>().Property(bl => bl.DueDate).IsRequired();
                builder.Entity<Bill>().Property(bl => bl.TotalAmount).IsRequired();
                builder.Entity<Bill>().Property(bl => bl.Currency).IsRequired();
                builder.Entity<Bill>().Property(bl => bl.BillStatus).IsRequired();
                builder.Entity<Bill>().Property(bl => bl.Description).IsRequired().HasMaxLength(300);

                //Relationships
                builder.Entity<Bill>().HasOne(bl => bl.Payment).WithOne(py => py.Bill).HasForeignKey<Bill>(bl => bl.PaymentId);
                builder.Entity<Bill>().HasOne(bl => bl.Tutor).WithMany(tt => tt.Bills).HasForeignKey(bl => bl.TutorId);

        }
    }
}
