using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04
{
    public class Guitarra
    {
        private static string Afinacao { get; set; }

        static Guitarra()
        {
            Afinacao = "sol";
        }

        private void TomAfinado()
        {
            Console.WriteLine($"A guitarra está com afinação em {Afinacao}");
        }

        public void Tocar()
        {
            TomAfinado();
        }

        public void Tocar(string AfinacaoAtual)
        {
            Afinacao = AfinacaoAtual;
            TomAfinado();
        }


    }
}