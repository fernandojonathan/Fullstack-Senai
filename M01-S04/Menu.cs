using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01_S04
{
    public static class Menu
    {
         
         public static int SelecionarOp ()
         {

            try
         
            {
                       
                
                Console.Clear();
                Console.WriteLine("Escolha uma opção abaixo: ");
                Console.WriteLine("1 - Inserir bebida ");
                Console.WriteLine("2 - Alterar bebida ");
                Console.WriteLine("3 - Excluir bebida ");
                Console.WriteLine("4 - Listar  bebidas ");
                Console.WriteLine("5 - Listar  sucos ");
                Console.WriteLine("6 - Listar  refrigerantes ");
                Console.WriteLine("7 - Sair \n");
            
                return int.Parse(Console.ReadLine());
            }
        
            catch (Exception ex)
            
            {
                    Console.WriteLine("Opção inválida!");
            }
27047849
27036030

            return SelecionarOp();

        }
        

             

     
       
    }
}


       








