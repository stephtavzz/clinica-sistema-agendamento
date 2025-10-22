using System;
using ProjetoConsultasEF.Services;

var medicoService = new MedicoService();
var pacienteService = new PacienteService();
var consultaService = new ConsultaService();

int opcao;

do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1 - Cadastrar Médico");
    Console.WriteLine("2 - Listar Médicos");
    Console.WriteLine("3 - Cadastrar Paciente");
    Console.WriteLine("4 - Listar Pacientes");
    Console.WriteLine("5 - Agendar Consulta");
    Console.WriteLine("6 - Listar Consultas");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine() ?? "0");

    switch (opcao)
    {
        case 1:
            medicoService.Adicionar();
            break;
        case 2:
            medicoService.Listar();
            break;
        case 3:
            pacienteService.Adicionar();
            break;
        case 4:
            pacienteService.Listar();
            break;
        case 5:
            consultaService.Agendar();
            break;
        case 6:
            consultaService.ListarConsultas();
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    Console.WriteLine();

} while (opcao != 0);