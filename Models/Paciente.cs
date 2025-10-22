using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoConsultasEF.Models
{
    public class Paciente
    {

        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }

        public string Cpf { get; set; } = string.Empty;


        public List<Consultas> Consultas { get; set; } = new List<Consultas>();
        
    }
}