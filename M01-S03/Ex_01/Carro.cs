using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_01
{
    public class Carros
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }

        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Tickets { get; set; }


        public void CadCarro (){
            
            
            Console.Clear();
            Console.WriteLine(".................... Pare Aqui ....................");
            Console.WriteLine("............... Cadastro de veículo ...............");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Informe a placa");
            Placa=Console.ReadLine();
            Console.WriteLine("Informe o modelo");
            Modelo=Console.ReadLine();
            Console.WriteLine("Informe a marca");
            Marca=Console.ReadLine();
            Console.WriteLine("Informe a cor");
            Cor=Console.ReadLine();
            
            
            
        } 

        public void ExibirCarros() {

            

        }
        
    }
}