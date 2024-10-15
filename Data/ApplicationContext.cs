﻿using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Category> Categories { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                  : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                        .HasMany<Author>(s => s.Authors)
                        .WithMany(c => c.Books)
                        .UsingEntity(e => e.ToTable("BookAuthor"));
        }
    }
}
