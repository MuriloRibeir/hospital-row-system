using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fila_hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            {
                GerenciadorFila gerenciadorFila = new GerenciadorFila();
                string opcao;

                do
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. Cadastrar e adicionar paciente à fila");
                    Console.WriteLine("2. Listar fila de pacientes");
                    Console.WriteLine("3. Atender paciente");
                    Console.WriteLine("q. Sair");
                    Console.Write("Escolha uma opção: ");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.Write("Digite o nome do paciente: ");
                            string nome = Console.ReadLine();

                            Console.Write("O paciente é prioritário? (s/n): ");
                            bool prioritario = Console.ReadLine().ToLower() == "s";

                            Paciente paciente = new Paciente(nome, prioritario);
                            gerenciadorFila.InserirPaciente(paciente);
                            break;

                        case "2":
                            gerenciadorFila.ListarFila();
                            break;

                        case "3":
                            gerenciadorFila.AtenderPaciente();
                            break;

                        case "q":
                            Console.WriteLine("Saindo...");
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                } while (opcao != "q");
            }
        }
    }
        
}
 