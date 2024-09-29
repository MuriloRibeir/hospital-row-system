using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fila_hospital
{
    public class GerenciadorFila
    {
        private List<Paciente> fila = new List<Paciente>();
        private const int limiteFila = 11;

        // Adiciona pacientes à fila com prioritários
        public void InserirPaciente(Paciente paciente)
        {
            if (fila.Count >= limiteFila)
            {
                Console.WriteLine("Fila cheia! Não é possível adicionar mais pacientes.");
                return;
            }

            // Pacientes prioritários vão para o início da fila
            if (paciente.Prioritario)
            {
                fila.Insert(0, paciente);
            }
            else
            {
                fila.Add(paciente);
            }

            Console.WriteLine($"Paciente {paciente.Nome} adicionado à fila.");
        }

        // Lista todos os pacientes
        public void ListarFila()
        {
            if (fila.Count == 0)
            {
                Console.WriteLine("A fila está vazia.");
                return;
            }

            Console.WriteLine("Fila de pacientes:");
            for (int i = 0; i < fila.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {fila[i]}");
            }
        }

        
        public void AtenderPaciente()
        {
            if (fila.Count == 0)
            {
                Console.WriteLine("Não há pacientes na fila para serem atendidos.");
                return;
            }

            Paciente pacienteAtendido = fila[0]; // O primeiro paciente
            fila.RemoveAt(0); // Remove o paciente
            Console.WriteLine($"Paciente {pacienteAtendido.Nome} foi atendido.");
        }

    }
}
 
