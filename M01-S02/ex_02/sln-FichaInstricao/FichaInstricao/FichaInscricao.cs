using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//classe 
namespace FichaInstricao
{



    // Declaração da Classe
    public class FichaInscricao
    {
        //atributos
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int MenorIdade { get; set; }

        //Construtor 
        public FichaInscricao( int id, 
                               string nome, 
                               DateTime dataNascimento, 
                               int menorIdade)
        {
           //Preencher as propriedades com os parametros recebidos do construtor.
            Id = id;
            Nome = nome;
            DataNascimento = DateTime.Now;
            MenorIdade= menorIdade;


        }
    }
}
