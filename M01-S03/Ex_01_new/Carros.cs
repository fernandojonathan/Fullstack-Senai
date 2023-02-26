using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_01_new
{
    public class Carros
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }

        public string Marca { get; set; }
        public string Cor { get; set; }
       
        public List<Tickets> Extrato { get; set; }

        public Carros()
        {
            Extrato = new List<Tickets>();
        }
                                                                            
         //Construtor abaixo criado para facilitar os testes, deve ser EXCLUIDO PARA ENTREGAR A ATIVIDADE.                                                                   
                                                                            //this chama o construtor anterior pois lá tem a lista
        public Carros(string placa, string modelo, string marca, string cor) : this()
        {
            Placa = placa;
            Modelo = modelo;
            Marca = marca;
            Cor = cor;
            
        }
         
    }
}
