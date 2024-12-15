using Microsoft.EntityFrameworkCore;
using Perfumeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfumeria.Data
{
    public class PerfumeriaContex : DbContext
    {
        public DbSet<Area> Areas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<MetodoDePago> MetodosDePago { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public PerfumeriaContex()
        { }
        public PerfumeriaContex(DbContextOptions<PerfumeriaContex> options) : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS ; User Id=sa ; Password=123 ; Database=PerfumeriaContext; MultipleActiveResultSets = True; Encrypt=False ");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>().HasData(new Area { Id = 1, Nombre = "Perfumeria" }, new Area { Id = 2, Nombre = "Costumbre" }
            );
            modelBuilder.Entity<Cliente>().HasData(new Cliente { Id = 1, Nombre = "Ramiro" }, new Cliente { Id = 2, Nombre = "Valentin" }
            );
            modelBuilder.Entity<MetodoDePago>().HasData(new MetodoDePago { Id = 1, Nombre = "MercadoPago" }, new MetodoDePago { Id = 2, Nombre = "Efectivo" }
            );
            modelBuilder.Entity<Producto>().HasData(new Producto { Id = 1, Nombre = "Boos" }, new Producto { Id = 2, Nombre = "Esmalte" }
           );
        }
    }
}
