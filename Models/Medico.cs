using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoConsultasEF.Models;

namespace ProjetoConsultasEF.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Especialidade { get; set; } = string.Empty;

        public string Crm { get; set; } = string.Empty;


        public List<Consultas> Consultas { get; set; } = new List<Consultas>();
    }
}