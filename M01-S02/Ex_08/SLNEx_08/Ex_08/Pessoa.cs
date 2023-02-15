using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public static void MostrarIdade()
        {
            CalcularIdade();
            Console.WriteLine($"Nome: {Nome}, tem {Idade} anos");
        } 

        private void CalcularIdade(DateTime DataNascimento)
        {

            var dataNascimento = new DateTime(1984, 1, 2);
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }
        }
    }
}
