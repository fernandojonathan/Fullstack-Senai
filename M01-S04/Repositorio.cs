using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01_S04
{
    public static class Repositorio
    {
        public static List<Bebidas> ListaBebidas { get; set;}
        public static List<Sucos> ListaSucos { get; set; }
        public static List<Refrigerantes> ListaRefrigerantes { get; set;}
        




        static Repositorio ()
        {

            if (ListaBebidas == null)
            {
                ListaBebidas = new List<Bebidas>();
            }
            
            if (ListaRefrigerantes == null)
            {
                ListaRefrigerantes = new List<Refrigerantes>();
            }
            
            if (ListaSucos == null)
            {
                ListaSucos = new List<Sucos>();
            }
            
        }

            public static void AddSuco (Sucos suco)
        {
            ListaSucos.Add(suco);
        }

        public static void AddRefrigerante (Refrigerantes refrigerante)
        {
            ListaRefrigerantes.Add(refrigerante);
        }

        public static void AddBebida (Bebidas bebida)
        {
            ListaBebidas.Add(bebida);
        }
        
        public static void AltBebida (Bebidas bebida)
        {
            foreach (var item in ListaBebidas.Where(listaEmMemoria => listaEmMemoria.Id == bebida.Id))
            {
                item.NomeBebida = bebida.NomeBebida;
            }
        }

        public static void RemoverBebida(int id)
        {
            var localBebida = ListaBebidas.FirstOrDefault(w => w.Id == id);
            if (localBebida != null)
            {
                ListaBebidas.Remove(localBebida);
            }
        }

        public static List<Bebidas> ListarBebidas()
        {
            return ListaBebidas;
        }

    }
}

      