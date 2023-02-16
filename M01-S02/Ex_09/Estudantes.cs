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
        public string Pai {get ; set; }

        public Estudantes(string materia, int nota) 
            {
              Materia = materia;
                Nota = nota;
            }
        public Estudantes(string materia, int nota, string pai): this (materia, nota )
        {
            Pai = pai;
        }
        public void Imprimir()
        {
            if (Nota < 7) 
            {

             Console.WriteLine($"Responsável: {Pai} | Matéria: {Materia} | Nota: {Nota} | Reprovado!");
        
            } else
                {
                 Console.WriteLine($"Responsável: {Pai} | Matéria: {Materia} | Nota: {Nota} | Aprovado!");
                }

        }


    }
}