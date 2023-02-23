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
       
        public List<Tickets> ListaTickets { get; set; }

       

        void CarrosTicket() {

            ListaTickets = new List<Tickets>();
            
        }

       /*  public void consCarro (string placa, string modelo, string marca, string cor)
        {

            Placa = placa;
            Modelo = modelo;
            Marca = marca;
            Cor = cor;
                        
        } */
       
    }
}
