using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_01_new
{
    public class Tickets
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public bool Ativo { get; set; }
        

        

        public void CadTicket(DateTime entrada, DateTime saida, bool ativo){
            
            Entrada = entrada;
            Saida = saida;
            Ativo = ativo;
            
        }

         
        void CalcTempo(){
               
                TimeSpan calc = Saida - Entrada;
                var Tempo = calc.TotalMinutes;
                                               
        void CalcValor(){
                               
                var valor = Tempo * 0.09;

            }
        }        


    }
}