using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using p1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace p1.DAL
{
    public class SongContext : DbContext
    {

        //public SongContext() : base("SongContext")
        //{

        //}

        public DbSet<File> Files { get; set; }

        public System.Data.Entity.DbSet<p1.Models.Song> Songs { get; set; }



        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //base.OnModelCreating(modelBuilder);
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}

    }
}