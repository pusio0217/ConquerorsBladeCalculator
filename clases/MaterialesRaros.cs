using Conqueros_Calculator.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquerors_Calculator.modelos
{
   public partial class Material:ICloneable
    {


      
        public static Material MaderaCompuesta(int cantidad)
        {
            return new Material(idioma.maderaCompuesta, 20, new List<Recurso> {
                Recurso.Roble(15),
                Recurso.Cedro(10),
                Recurso.Carbon(1),
                Recurso.Tejo(1),
         

            }, cantidad, Rareza.Epico, "maderaCompuesta.PNG");
        }

        public static Material MaderaBarnizada(int cantidad)
        {
            return new Material(idioma.maderaBarnizada, 20, new List<Recurso> {
                Recurso.Roble(-5000),
                Recurso.Cedro(-5000),
                Recurso.Carbon(-5000),
                Recurso.Tejo(-5000)


            }, cantidad, Rareza.Epico, "maderaCompuesta.PNG");
        }



        public static Material CueroPerfeccionado(int cantidad)
        {
            return new Material(idioma.cueroPerfeccionado, 20, new List<Recurso> {
                Recurso.Cabra(15),
                Recurso.Vaca(10),
                Recurso.Tendones(1),
                Recurso.PielBisonte(1)

            }, cantidad, Rareza.Epico, "cueroPerfeccionado.PNG");
        }
       
        public static Material HierroPuro(int cantidad)
        {
            return new Material(idioma.hierroPuro, 20, new List<Recurso> {
                Recurso.Hematita(10),
                Recurso.Limonita(15),
                Recurso.Carbon(1),
               Recurso.BauxitaMontaña(1)

            }, cantidad, Rareza.Epico, "hierroPuro.PNG");
        }
       
        public static Material TelaCalidad(int cantidad)
        {
            return new Material(idioma.telaCalidad, 20, new List<Recurso> {
                Recurso.AlgodonAltaCalidad(15),
                 Recurso.AlgodonMejorCalidad(10),
                Recurso.Cañamo(1),
                Recurso.AlgodonNube(1),
            
            }, cantidad, Rareza.Epico, "telaExcelente.PNG");
        }

      
        public static Material TelaExcelente(int cantidad)
        {
            return new Material(idioma.telaExceletne, 20, new List<Recurso> {
                Recurso.AlgodonAltaCalidad(15),
                 Recurso.AlgodonMejorCalidad(10),
                Recurso.Pelajes(1),
                Recurso.AlgodonMontaña(1),
            }, cantidad, Rareza.Epico, "telaExcelente.PNG");
        }

        
        public static Material HierroForjado(int cantidad)
        {
            return new Material(idioma.hierroForjado, 20, new List<Recurso> {
                Recurso.Limonita(15),
                 Recurso.Hematita(10),
                Recurso.ManganesoNegro(1),
                Recurso.Tungsteno(1),

            }, cantidad, Rareza.Epico, "hierroPuro.PNG");
        }

      
        public static Material CobreRefinado(int cantidad)
        {
            return new Material(idioma.cobreRefinado, 20, new List<Recurso> {
                Recurso.Digenita(15),
                 Recurso.Cuprita(10),
                Recurso.Carbon(1),
                Recurso.Minio(1),

            }, cantidad, Rareza.Epico, "cobrePuro.PNG");
        }

       
        public static Material CobrePuro(int cantidad)
        {
            return new Material(idioma.cobrePuro, 20, new List<Recurso> {
                Recurso.Digenita(15),
                 Recurso.Cuprita(10),
                Recurso.Alumbre(1),
                Recurso.Fosforo(1),

            }, cantidad, Rareza.Epico, "cobrePuro.PNG");
        }

     
        public static Material CueroHervido(int cantidad)
        {
            return new Material(idioma.cueroHervido, 20, new List<Recurso> {
                Recurso.Cabra(15),
                 Recurso.Vaca(10),
                Recurso.NitratoPotasio(1),
                Recurso.PelajeLoboMontaña(1),

            }, cantidad, Rareza.Epico, "cueroPerfeccionado.PNG");
        }

      
        public static Material PiedraPerfeccionada(int cantidad)
        {
            return new Material(idioma.piedraPerfeccionada, 20, new List<Recurso> {
                Recurso.Marmol(15),
                 Recurso.Granito(10),              

            }, cantidad, Rareza.Epico, "");
        }

      
        public static Material PiedraDetallada(int cantidad)
        {
            return new Material(idioma.piedraDetallada, 20, new List<Recurso> {
                Recurso.Marmol(15),
                 Recurso.Granito(10),

            }, cantidad, Rareza.Epico, "");
        }

    }
}
