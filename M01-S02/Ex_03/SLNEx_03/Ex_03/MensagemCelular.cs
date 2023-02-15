using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    public class MensagemCelular
    {
        public int Telefone { get; set; }
        public string Mensagem { get; set;}

        public void Executar()
        {
            Console.WriteLine("Metódo Executado pelo Console");
            EnviarMensagemAoTelefone();
        }
        private void EnviarMensagemAoTelefone()
        {
            Console.WriteLine("Método privado executado na classe");
            Console.WriteLine($"Telefone: {Telefone}, Mensagem: {Mensagem}");
        }

      
    }
    
}
