using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

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

        }

        #endregion
    }
}
