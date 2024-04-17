using Library.Configurations;
using Library.Initializer;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Library.Context
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataInitializer.Seed(modelBuilder);
            //Operation
            modelBuilder.ApplyConfiguration(new OperationConfiguration());

            //Student
            modelBuilder.ApplyConfiguration(new StudentConfiguration());

            //Book
            modelBuilder.ApplyConfiguration(new BookConfiguration());


        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<AppUser> Users { get; set; }


    }
}
