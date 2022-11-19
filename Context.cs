using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DB_Lab_10
{
    public class Context : DbContext
    {
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Books { get; set; }

        public Context() : base()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database = Books; Trusted_Connection = True;");
        }

    }


    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Book> Books { get; set; }
       

    }



}
