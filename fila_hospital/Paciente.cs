using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fila_hospital
{
    public class Paciente
    {
        public string Nome { get; private set; }
        public bool Prioritario { get; private set; }

        // Construtor
        public Paciente(string nome, bool prioritario = false)
        {
            Nome = nome;
            Prioritario = prioritario;
        }

        // Sobrescreve o metodo "toString"
        public override string ToString()
        {
            return Prioritario ? "(PRIORITÁRIO) " + Nome : Nome;
        }
    }
}