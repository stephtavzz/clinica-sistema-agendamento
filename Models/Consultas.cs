using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoConsultasEF.Models
{
    public class Consultas
    {
        public int Id { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public int MedicoId { get; set; } 
        public Medico Medico { get; set; } = null!;
        public int PacienteId { get; set; } 
        public Paciente Paciente { get; set; } = null!;

    }
}