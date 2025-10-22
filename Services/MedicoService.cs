using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoConsultasEF.Data;
using ProjetoConsultasEF.Models;

namespace ProjetoConsultasEF.Services
{
    public class MedicoService
    {
        private readonly AppDbContext _context = new AppDbContext();

        public void Adicionar()
        {
            var m = new Medico();
            Console.Write("Nome do médico: ");
            m.Nome = Console.ReadLine() ?? "";
            Console.Write("Especialidade: ");
            m.Especialidade = Console.ReadLine() ?? "";
            Console.Write("CRM: ");
            m.Crm = Console.ReadLine() ?? "";

            _context.Medicos.Add(m);
            _context.SaveChanges();
            Console.WriteLine("Médico cadastrado!");
        }

        public void Listar()
        {
            var medicos = _context.Medicos.ToList();

            if (!medicos.Any()) { Console.WriteLine("Nenhum médico cadastrado."); return; }
            
            foreach (var m in medicos)
                Console.WriteLine($"{m.Id} - {m.Nome} - {m.Especialidade} - CRM: {m.Crm}");
        }
    }
}