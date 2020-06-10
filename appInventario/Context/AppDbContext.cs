using appInventario.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appInventario.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Colaborador> Colaboradores { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Rol>()
               .HasMany(b => b.Colaboradores);

        }


        //public DbSet<Rol> Rol { get; set; }
        //public DbSet<Proyecto> Proyecto { get; set; }
        //public DbSet<Laptop> Laptop { get; set; }
        //public DbSet<Maestro> Maestro { get; set; }
        //public DbSet<Colaborador> Colaborador { get; set; }

    }
}
