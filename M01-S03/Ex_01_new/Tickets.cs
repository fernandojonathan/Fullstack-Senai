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
        
   
        public Tickets (DateTime entrada, bool ativo) 
        
        {
            
            Entrada = entrada;
            // defino o default no cadastro, e o atributo deve apenas ser modificado e não adicionado
            // faz diferença? quem sabe, teste depois carniça...
            Ativo = ativo;
            
        }
        public Tickets (bool ativo, DateTime saida) 
        
        {
            
            Saida = saida;
            Ativo = ativo;
            
        }

         
              


    }
}