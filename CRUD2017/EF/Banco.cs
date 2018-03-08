using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CRUD2017.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace CRUD2017.EF
{
    public class Banco : DbContext
    {
        //teste
        public Banco() : base("conexao") { }
        public DbSet<Programador> Programadores { get; set; }
        public DbSet<Conhecimento> Conhecimentos { get; set; }
        public DbSet<DBancario> DBancarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Conhecimento>()
                .HasKey(c => c.cod_prog_id);

            modelBuilder.Entity<Programador>()
                .HasKey(c => c.cod_prog_id);

            modelBuilder.Entity<DBancario>()
                .HasKey(c => c.cod_prog_id);

            modelBuilder.Entity<Endereco>()
                .HasKey(c => c.cod_prog_id);

            modelBuilder.Entity<Programador>()
                .HasRequired(p => p.Conhecimento)
                .WithRequiredPrincipal(ad => ad.Programador).WillCascadeOnDelete(true);

            modelBuilder.Entity<Programador>()
                .HasRequired(p => p.DBancario)
                .WithRequiredPrincipal(ad => ad.Programador).WillCascadeOnDelete(true);

            modelBuilder.Entity<Programador>()
                .HasRequired(p => p.Endereco)
                .WithRequiredPrincipal(ad => ad.Programador).WillCascadeOnDelete(true);



        }



    }
}