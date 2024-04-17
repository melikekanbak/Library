using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Library.Initializer
{
    public static class DataInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            string password1 = BCrypt.Net.BCrypt.HashPassword("123");
            string password2 = BCrypt.Net.BCrypt.HashPassword("1234");
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser() { ID = 1, UserName = "administrator", Password = password1, Role = Enums.Role.admin },
                new AppUser() { ID = 2, UserName = "melike", Password = password2, Role = Enums.Role.user }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student() { ID = 1, FirstName = "Emirhan", LastName = "Yeşil", Gender = Enums.Gender.Erkek },
                new Student() { ID = 2, FirstName = "Safa", LastName = "Başdemir", Gender = Enums.Gender.Erkek },
                new Student() { ID = 3, FirstName = "Gürkan", LastName = "Taş", Gender = Enums.Gender.Erkek },
                new Student() { ID = 4, FirstName = "Zeynep", LastName = "Kurt", Gender = Enums.Gender.Kadın }
                );

            modelBuilder.Entity<StudentDetail>().HasData(
               new StudentDetail() { ID = 1, StudentID=1,SchoolNumber="100", BirthDay= new DateTime(1997,11,30) },
               new StudentDetail() { ID = 2, StudentID = 2, SchoolNumber = "101", BirthDay = new DateTime(1997, 11, 30) },
               new StudentDetail() { ID = 3, StudentID = 3, SchoolNumber = "102", BirthDay = new DateTime(1992, 11, 30) },
               new StudentDetail() { ID = 4, StudentID = 4, SchoolNumber = "103", BirthDay = new DateTime(1990, 11, 30) }
               );

        }
    }
}
