using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TrabajoPracticoApi.Model;

namespace TrabajoPracticoApi.Data
{
    public class Application : DbContext
    {
        public DbSet<Persona> personas { get; set; }
        public DbSet<Animal> animales { get; set; }
        public DbSet<Historial> historiales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=VARIAS\\SQLEXPRESS;database=Api;trusted_connection=true;Encrypt=False");
        }
    }
}
