using appInventario.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appInventario.Context
{
    public class AppDbBuscaColaborador: DbContext
    {
        public AppDbBuscaColaborador(DbContextOptions<DbContext> options ): base(options)
        { 
            
        }

        public DbSet<Rol> Rols { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Rol>()
        //       .HasMany(b => b.Colaboradores);
        //}

    }
}
