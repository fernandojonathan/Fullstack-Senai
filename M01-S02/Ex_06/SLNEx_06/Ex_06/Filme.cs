using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06
{
    public class Filme
    {
        public string NomeFilme { get; set; }
        public string Categoria { get; set; }

        public void Informe(string NomeFilme, string Categoria)
        {
            Console.WriteLine($"Nome do filme: {NomeFilme}, categoria {Categoria}");
        }
    }
}
