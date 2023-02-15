using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public class Estudantes
    {
        public string Materia { get; set; }
        public int Nota { get; set; }

        public Estudantes(string materia, int nota) {
            Materia = materia;
            Nota = nota;
        }

        public void Imprimir()
        {
            if (Nota < 7) {

             Console.WriteLine($"Matéria: {Materia} | Nota: {Nota} | Reprovado!");
        
        } else
            {
             Console.WriteLine($"Matéria: {Materia} | Nota: {Nota} | Aprovado!");
            }

        }


    }
}
