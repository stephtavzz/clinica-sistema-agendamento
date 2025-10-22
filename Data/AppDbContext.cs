using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoConsultasEF.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoConsultasEF.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Medico> Medicos => Set<Medico>();
        public DbSet<Paciente> Pacientes => Set<Paciente>();
        public DbSet<Consultas> Consultas => Set<Consultas>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KSNRCTI\\SQLEXPRESS;Database=DBConsultas;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}