
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFECore
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFCoreRel;Integrated Security=True;Encrypt=true;Trust Server Certificate=true;");
            options.UseSqlServer(@"Data Source=DESKTOP-5A0QPBF;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Initial Catalog=EFCoreRel;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Post>().HasIndex(p => p.title);
            //modelBuilder.Entity<person>().HasIndex(p => new { p.firstname , p.lastname });
            modelBuilder.Entity<person>().HasIndex(p => p.username).IsUnique()
                .HasName("new_person_name_user_name_111")
                ;

            // one to one relation
            //modelBuilder.Entity<Post>()
            //    .HasOne(b => b.image)
            //    .WithOne(i => i.post)
            //    .HasForeignKey<image>(i => i.post_id);
            // one to many 

            // one To Many
            //modelBuilder.Entity<Post>()
            //    .HasMany<image>()
            //    .WithOne()
            //    .HasForeignKey("post_id")
            //    .HasConstraintName("PostTest");

            // many to many









    }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Nationality> Nationality { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<image> images { get; set; }   
        public DbSet<person> Persons { get; set; }   
        public DbSet<Stock> Stocks { get; set; }   
        //public DbSet<postImage> postImage { get; set; }   
    }



    //[Index(nameof(title))]
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }

        //public List<image> image { get; set; }
    }


    public class image
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    //[Index(nameof(firstname) , nameof(lastname))]
    //[Index(nameof(username) , IsUnique=false , Name="username_index_person_14")]
    public class person { 
        public int id { get; set; }
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname{ get; set; }
    }


    //public class postImage {

    //    public int id { get; set; }
    //    public image Image { get; set; }
    //    public Post post{ get; set; }

    //}


    //public class postImage {

    //    public int id { get; set; }
    //    public image Image { get; set; }
    //    public Post post{ get; set; }

    //}

    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Sector { get; set; }
        public string Industry { get; set; }
        public double Balance { get; set; }

        
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }


    public class Author
    {
        public int Id { get; set; }
        public int? NationalityId { get; set; }
        public string Name { get; set; }
        public Nationality nationality { get; set; }
        public List<Book> Books { get; set; }
    }


    public class Nationality
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

}
