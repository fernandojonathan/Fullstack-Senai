using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01_S04
{
    public class Sucos : Bebidas
    {
        public string TipoCaixa { get; set; }





    public Sucos (string tipoCaixa, int id, string nomeBebida, decimal miliLitros) : base (id, nomeBebida, miliLitros)
        {
           this.TipoCaixa = tipoCaixa;
        }
    public void ImprimirDados() {
            
            Console.WriteLine($"O produto id {Id} é um suco é do tipo {TipoCaixa} com quantidade de MiliLitros {MiliLitros}");
        
        }

    }

    
}