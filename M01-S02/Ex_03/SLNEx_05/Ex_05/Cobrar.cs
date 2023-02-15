using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
    internal class Cobrar
    {
        private decimal Valor { get; set; }
        private decimal Multa { get; set; }

        public CalculosCons (decimal valor, decimal multa)
        {
            Valor = valor;
            Multa = multa;
        
        
        
        
        }

        private static void CalcularMulta(decimal valor, decimal Multa)
        {
            decimal somaValor = valor + Multa;

        }
        public static void Calcular()
        {
            CalcularMulta();
            Console.WriteLine($"Valor cobrado {valor}, Multa {Multa}, soma valor {somaValor}");
        }



    }
}
