using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
    public class Cobrar
    {
        
        private decimal Valor { get; set; }
        private decimal Multa { get; set; }
        public decimal CalculoMulta { get ; set; }

      
        public  Calculos (decimal valor, decimal multa)
        {
            Valor = valor;
            Multa = multa;
            
            CalculoMulta = valor +multa;
            
        }
       
       
        



    }
}
