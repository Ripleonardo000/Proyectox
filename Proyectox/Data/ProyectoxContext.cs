using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyectox.Models;

namespace Proyectox.Data
{
    public class ProyectoxContext : DbContext
    {
        public ProyectoxContext (DbContextOptions<ProyectoxContext> options)
            : base(options)
        {
        }

        public DbSet<Proyectox.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<Proyectox.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<Proyectox.Models.Liga> Liga { get; set; } = default!;
    }
}
