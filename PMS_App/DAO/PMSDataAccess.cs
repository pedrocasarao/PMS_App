using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PMS_App.Models;

namespace PMS_App.ET
{
    public class PMSDataAccess : DbContext
    {
        public PMSDataAccess() : base("name=dbconnection")
        {
            Database.SetInitializer(new NullDatabaseInitializer<PMSDataAccess>());
        }
        public DbSet<Projeto> PMSlistProjeto { get; set; }

        public DbSet<Usuario> PMSlistUsuario { get; set; }

        public DbSet<Ocorrencia> PMSlistOcorrencia { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Usuario>().HasKey(x => x.Matricula);

        }
    }
}