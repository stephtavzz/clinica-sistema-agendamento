using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoConsultasEF.Data;
using ProjetoConsultasEF.Models;

namespace ProjetoConsultasEF.Services
{
    public class ConsultaService
    {
        private readonly AppDbContext _context = new AppDbContext();

        public void Agendar()
        {
            Console.WriteLine("Id do Médico: ");
            int idMedico = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Id do Paciente: ");
            int idPaciente = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Data da Consulta (AAAA-MM-DD HH:MM): ");
            DateTime dataConsulta = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString());

            var medico = _context.Medicos.Find(idMedico);
            var paciente = _context.Pacientes.Find(idPaciente);

            if (medico == null || paciente == null)
            {
                Console.WriteLine("Médico ou Paciente não encontrado.");
                return;
            }

            var consulta = new Consultas
            {
                MedicoId = idMedico,
                PacienteId = idPaciente,
                DataConsulta = dataConsulta,
                Descricao = $"Consulta agendada para {dataConsulta:dd/MM/yyyy HH:mm}"
            };

            _context.Consultas.Add(consulta);
            _context.SaveChanges();
            Console.WriteLine("Consulta agendada com sucesso!");
        }

        public void ListarConsultas()
        {
            var consultas = _context.Consultas
                .Select(c => new
                {
                    c.Id,
                    c.DataConsulta,
                    c.Descricao,
                    MedicoNome = c.Medico.Nome,
                    PacienteNome = c.Paciente.Nome
                }).ToList();

            if(!consultas.Any()) { Console.WriteLine("Nenhuma consulta agendada."); return; }

            foreach (var consulta in consultas)
            {
                Console.WriteLine($"Id: {consulta.Id} - Data: {consulta.DataConsulta} - Médico: {consulta.MedicoNome} - Paciente: {consulta.PacienteNome} - Descrição: {consulta.Descricao}");
            }
        }
    }
}