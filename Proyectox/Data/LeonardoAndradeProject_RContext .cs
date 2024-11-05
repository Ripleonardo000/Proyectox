using Proyectox.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Proyectox.Data
{
    public class LeonardoAndradeProject_RContext : DbContext
    {

        public DbSet<Liga> Ligas { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        //pub

        public LeonardoAndradeProject_RContext(DbContextOptions<LeonardoAndradeProject_RContext> options)
            : base(options)
        {
        }
    }
}
