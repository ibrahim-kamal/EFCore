﻿using EFECore.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Image = EFECore.models.Image;

namespace EFECore
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFCore;Integrated Security=True;Encrypt=true;Trust Server Certificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(e => e.Password).IsRequired();
            modelBuilder.Entity<Student>();
            modelBuilder.Ignore<TestUser>();
            // if happend any change on model no colums will remove or add -- 
            modelBuilder.Entity<User>().ToTable("Users" , b=>b.ExcludeFromMigrations());
            //modelBuilder.Entity<Student>().Ignore("Token");
            modelBuilder.Entity<Student>().Ignore(s => s.Token);
            modelBuilder.Entity<Post>().ToTable("My_Posts");
            modelBuilder.Entity<CatImage>().ToTable("CatImages" , schema:"testSchema");
            modelBuilder.HasDefaultSchema("mySchema");
            modelBuilder.Entity<Post>().Property(p=>p.title).HasColumnName("Title");
            modelBuilder.Entity<Post>().Property(p=>p.Content).HasColumnType("text");
            modelBuilder.Entity<Post>(p =>
            {
                p.Property(p => p.Content).HasColumnType("text");
                p.Property(p => p.Id).HasColumnType("BigInt");
            });
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<category> category { get; set; }
    }
}
