using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01_S04
{
    public class Refrigerantes : Bebidas
    {
        public bool Vidro { get; set; }


        public Refrigerantes (bool vidro, int id, string nomeBebida, decimal miliLitros) : base (id, nomeBebida, miliLitros)
        {
           this.Vidro = vidro;
        }


        public void ImprimirDados  ( ){
       
            Console.Clear();
            Console.WriteLine($"O produto id {Id} com nome {NomeBebida} é um refrigerante MiliLitros {MiliLitros} ml é um vidro”");
        
        

     }
    }

        
        
}