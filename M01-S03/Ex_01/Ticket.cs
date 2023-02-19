using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_01
{
    public class Tickets
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public bool Ativo { get; set; }
        public double Valor {  get ; set; }


        
        public DateTime CadEntrada (){
            
            Console.Clear();
            Console.WriteLine(".................... Pare Aqui ....................");
            Console.WriteLine("................ Emissão de tícket ................");
            Console.WriteLine("..................... Entrada ..................... ");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Cadastrar manualmente a Entrada? (S/N)");
            var op = Console.ReadLine();

            if (op == "s") {
                 Console.Clear();
                 Console.WriteLine(".................... Pare Aqui ....................");
                 Console.WriteLine("................ Emissão de tícket ................");
                 Console.WriteLine("..................... Entrada ..................... ");
                 Console.WriteLine("");
                 Console.WriteLine("");                
                 Console.WriteLine("Qual a data e hora de entrada? ARRUMAR O FORMATO");
                 Console.WriteLine("Ajustar código para receber a entrada do usuário");
                 DateTime now = DateTime.Now;
                 Console.WriteLine($"Entrada cadastrada: {now}");
                 Console.ReadLine();
                 return Entrada = DateTime.Now;

            } else {
                 Console.Clear();
                 Console.WriteLine(".................... Pare Aqui ....................");
                 Console.WriteLine("................ Emissão de tícket ................");
                 Console.WriteLine("..................... Entrada ..................... ");
                 Console.WriteLine("");
                 Console.WriteLine("");
                 DateTime now = DateTime.Now;
                 Console.WriteLine($"Entrada cadastrada: {now}");
                 Console.ReadLine();
                 return Entrada = DateTime.Now;

            }
        }

         public DateTime CadSaida (){
                       
            Console.Clear();
            Console.WriteLine(".................... Pare Aqui ....................");
            Console.WriteLine("................ Emissão de tícket ................");
            Console.WriteLine("..................... Saída ..................... ");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Cadastrar manualmente a Saída? (S/N)");
            var op = Console.ReadLine();

            if (op == "s") {
                 Console.Clear();
                 Console.WriteLine(".................... Pare Aqui ....................");
                 Console.WriteLine("................ Emissão de tícket ................");
                 Console.WriteLine("...................... Saída ...................... ");
                 Console.WriteLine("");
                 Console.WriteLine("");                
                 Console.WriteLine("Qual a data e hora de Saída? ARRUMAR O FORMATO");
                 Console.WriteLine("Ajustar código para receber a Saída do usuário");
                 DateTime now = DateTime.Now;
                 Console.WriteLine($"Saída cadastrada: {now}");
                 Console.ReadLine();
                 return Saida = DateTime.Now;

            } else {
                 Console.Clear();
                 Console.WriteLine(".................... Pare Aqui ....................");
                 Console.WriteLine("................ Emissão de tícket ................");
                 Console.WriteLine("...................... Saída ...................... ");
                 Console.WriteLine("");
                 Console.WriteLine("");
                 DateTime now = DateTime.Now;
                 Console.WriteLine($"Saída cadastrada: {now}");
                 Console.ReadLine();
                 return Saida = DateTime.Now;

            }
        }
        public void CalcValor(){
                TimeSpan calc = Saida - Entrada;
                var Tempo = calc.TotalMinutes;
                Console.WriteLine("Tempo de permanência: "+ Tempo);
               
                var valor = Tempo * 0.09;
                Console.WriteLine($"Valor do tícket: {valor}");
                Console.ReadLine();
                              
        }

      


        /* public bool CalcAtivo {
            var saida = bool.
            if (saída < ) {

        } */
        }

        
}
