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

        #region DbSets

        public DbSet<User> users { get; set; }

        #endregion



        #region Modelbuilder

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(b => b.UserId);
            modelBuilder.Entity<User>().Property(b => b.UserId).ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().Property(b => b.UserName);
            modelBuilder.Entity<User>().Property(b => b.AcessRights);
            modelBuilder.Entity<User>().Property(b => b.FirstName);
            modelBuilder.Entity<User>().Property(b => b.LastName);
        }

        #endregion
    }
}
