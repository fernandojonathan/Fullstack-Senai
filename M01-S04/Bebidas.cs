using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01_S04
{
    public class Bebidas
    {
        public int Id { get; set; }
        public string Refrigerante { get; set; }
        public string Suco { get; set; }
        public decimal MiliLitros{ get; set; }
        public string NomeBebida { get; set; }
        public decimal ValorCompra{ get; set; }


        public Bebidas(int id, string nomeBebida, decimal miliLitros)
        {
            Id = id;
            NomeBebida = nomeBebida;
            MiliLitros = miliLitros;

        }

        public void Comprar() {
            
            Console.WriteLine($"Valor da compra do produto id {Id} alterado para {ValorCompra}");
        
        }
       
    }
}