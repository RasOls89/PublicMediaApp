using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Models;

namespace DataLayer.Internals
{
    public class PublicMediaContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PublicMediaApp");
        }


        #region DbSets

        public DbSet<User> users { get; set; }
        public DbSet<Music> musics { get; set; }
        public DbSet<Game> games { get; set; }
        public DbSet<Book> books { get; set; }

        #endregion


        #region Modelbuilder

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            ///User modelbuilder
            modelBuilder.Entity<User>().HasKey(b => b.UserId);
            modelBuilder.Entity<User>().Property(b => b.UserId).ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().Property(b => b.UserName);
            modelBuilder.Entity<User>().Property(b => b.AcessRights);
            modelBuilder.Entity<User>().Property(b => b.Role);
            modelBuilder.Entity<User>().Property(b => b.FirstName);
            modelBuilder.Entity<User>().Property(b => b.LastName);
            ///Seed for User
            modelBuilder.Entity<User>().HasData
            (new User { UserId = 1, UserName = "Admin", Role = "HuvudAdmin", Password = "Admin1", AcessRights = "System", FirstName ="Rasmus", LastName="Olsson" });

            ///Music modelbuilder
            modelBuilder.Entity<Music>().HasKey(b => b.MusicId);
            modelBuilder.Entity<Music>().Property(b => b.MusicId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Music>().Property(b => b.BandName);
            modelBuilder.Entity<Music>().Property(b => b.Titel);
            modelBuilder.Entity<Music>().Property(b => b.Genre);
            modelBuilder.Entity<Music>().Property(b => b.Year);
            modelBuilder.Entity<Music>().Property(b => b.Format);

            ///Games modelbuilder
            modelBuilder.Entity<Game>().HasKey(b => b.GameId);
            modelBuilder.Entity<Game>().Property(b => b.GameId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Game>().Property(b => b.Titel);
            modelBuilder.Entity<Game>().Property(b => b.Genre);
            modelBuilder.Entity<Game>().Property(b => b.Year);
            modelBuilder.Entity<Game>().Property(b => b.Console);
            modelBuilder.Entity<Game>().Property(b => b.Developer);

            //Book modelbuilder
            modelBuilder.Entity<Book>().HasKey(b => b.BookId);
            modelBuilder.Entity<Book>().Property(b => b.BookId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Book>().Property(b => b.FNAuthor);
            modelBuilder.Entity<Book>().Property(b => b.ENAuthor);
            modelBuilder.Entity<Book>().Property(b => b.Titel);
            modelBuilder.Entity<Book>().Property(b => b.Genre);
            modelBuilder.Entity<Book>().Property(b => b.ISBN);
        }

        #endregion
    }
}
