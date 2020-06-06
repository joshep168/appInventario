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

        public DbSet<Rol> Rol { get; set; }
        public DbSet<Proyecto> Proyecto { get; set; }
        public DbSet<Laptop> Laptop { get; set; }
        public DbSet<Maestro> Maestro { get; set; }

    }
}
