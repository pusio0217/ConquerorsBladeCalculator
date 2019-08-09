using Conqueros_Calculator.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquerors_Calculator.modelos
{
  public partial  class Material
    {
      
        public static Material TelaBarata(int cantidad)
        {
            return new Material(idioma.telaBarata, 5, new List<Recurso> {
                Recurso.AlgodonPocaCalidad(25),
                Recurso.AlgodonCalidadMedia(10),
                Recurso.AlgodonAltaCalidad(8),
                Recurso.AlgodonMejorCalidad(7),
                Recurso.Lino(1)

            }, cantidad, Rareza.Raro, "telaBarata.PNG");
        }

    
        public static Material HierroFundido(int cantidad)
        {
            return new Material(idioma.hierroFundido, 5, new List<Recurso> {
                Recurso.Siderita(25),
                Recurso.Magnetita(10),
                Recurso.Limonita(8),
                Recurso.Hematita(7),
                Recurso.Calamina(1)

            }, cantidad, Rareza.Raro, "hierroFundido.PNG");
        }


      

      
        public static Material CobreMejorado(int cantidad)
        {
            return new Material(idioma.cobreMejorado, 5, new List<Recurso> {
                Recurso.Calcopirita(25),
                Recurso.Calcosina(10),
                Recurso.Digenita(8),
                Recurso.Cuprita(7),
                Recurso.Estaño(1)

            }, cantidad, Rareza.Raro, "cobreMejorado.PNG");
        }
     
        public static Material CueroTratado(int cantidad)
        {
            return new Material(idioma.cueroTratado, 5, new List<Recurso> {
                Recurso.Cerdo(25),
                Recurso.Oveja(10),
                Recurso.Cabra(8),
                Recurso.Vaca(7),
                Recurso.GomaLaca(1)

            }, cantidad, Rareza.Raro, "cueroTratado.PNG");
        }

      
    
        public static Material MaderaAlisada(int cantidad)
        {
            return new Material(idioma.maderaAlisada, 5, new List<Recurso> {
                Recurso.Pino(25),
                Recurso.Fresno(10),
                Recurso.Roble(8),
                Recurso.Cedro(7),
                Recurso.Tendones(1)

            }, cantidad, Rareza.Raro, "maderaAlisada.PNG");
        }

     
        public static Material PiedraCortada(int cantidad)
        {
            return new Material(idioma.piedraCortada, 5, new List<Recurso> {
                Recurso.Arenisca(25),
                Recurso.RocaCaliza(10),
                Recurso.Marmol(8),
                Recurso.Granito(7),

            }, cantidad, Rareza.Raro, "piedraCortada.PNG");
        }

    }
}
