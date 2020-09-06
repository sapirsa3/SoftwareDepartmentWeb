using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using projectnetwork.Models;

namespace projectnetwork.Dal
{
    public class LoginDal : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Login>().ToTable("login_users");
            modelBuilder.Entity<Admin>().ToTable("users");
        }
        public DbSet<Login> Userslogin { get; set; }
        public DbSet<Admin> Users { get; set; }

    }
}