using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ProjetoConsultasEF.Data;
using ProjetoConsultasEF.Models;

namespace ProjetoConsultasEF.Services
{
    public class PacienteService
    {
        private readonly AppDbContext _context = new AppDbContext();

        public void Adicionar()
        {
            var p = new Paciente();
            Console.Write("Nome do paciente: ");
            p.Nome = Console.ReadLine() ?? "";
            Console.Write("Data de nascimento (AAAA-MM-DD): ");
            p.DataNascimento = DateTime.Parse(Console.ReadLine() ?? "");
            Console.Write("CPF: ");
            p.Cpf = Console.ReadLine() ?? "";

            _context.Pacientes.Add(p);
            _context.SaveChanges();
            Console.WriteLine("Paciente cadastrado!");
        }

        public void Listar()
        {
            var pacientes = _context.Pacientes.ToList();

            if (!pacientes.Any()) { Console.WriteLine("Nenhum paciente cadastrado."); return; }
            
            foreach (var p in pacientes)
                Console.WriteLine($"{p.Id} - {p.Nome} - Nascido em {p.DataNascimento:dd/MM/yyyy} - CPF: {p.Cpf}");
        }
    }
}