using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conqueros_Calculator.modelos
{
   public partial class Material:ICloneable
    {


        public static readonly string TMaderaCompuesta = "Madera compuesta";
        public static Material MaderaCompuesta(int cantidad)
        {
            return new Material(TMaderaCompuesta, 20, new List<Recurso> {
                Recurso.Roble(15),
                Recurso.Cedro(10),
                Recurso.Carbon(1),
                Recurso.Tejo(1),
         

            }, cantidad, Rareza.Epico, "");
        }


        public static readonly string TCueroPerfeccionado = "Cuero perfeccionado";
        public static Material CueroPerfeccionado(int cantidad)
        {
            return new Material(TCueroPerfeccionado, 20, new List<Recurso> {
                Recurso.Cabra(15),
                Recurso.Vaca(10),
                Recurso.Tendones(1),
                Recurso.PielBisonte(1)

            }, cantidad, Rareza.Epico, "cueroPerfeccionado.PNG");
        }
        public static readonly string THierroPuro = "Hierro puro";
        public static Material HierroPuro(int cantidad)
        {
            return new Material(THierroPuro, 20, new List<Recurso> {
                Recurso.Hematita(10),
                Recurso.Limonita(15),
                Recurso.Carbon(1),
               Recurso.BauxitaMontaña(1)

            }, cantidad, Rareza.Epico, "hierroPuro.PNG");
        }
        public static readonly string TTelaCalidad = "Tela de calidad";
        public static Material TelaCalidad(int cantidad)
        {
            return new Material(TTelaCalidad, 20, new List<Recurso> {
                Recurso.AlgodonAltaCalidad(15),
                 Recurso.AlgodonMejorCalidad(10),
                Recurso.Cañamo(1),
                Recurso.AlgodonNube(1),
            
            }, cantidad, Rareza.Epico, "");
        }

        public static readonly string TTelaExcelente = "Tela excelente";
        public static Material TelaExcelente(int cantidad)
        {
            return new Material(TTelaExcelente, 20, new List<Recurso> {
                Recurso.AlgodonAltaCalidad(15),
                 Recurso.AlgodonMejorCalidad(10),
                Recurso.Pelajes(1),
                Recurso.AlgodonMontaña(1),
            }, cantidad, Rareza.Epico, "");
        }

        public static readonly string THierroForjado = "Hierro forjado";
        public static Material HierroForjado(int cantidad)
        {
            return new Material(THierroForjado, 20, new List<Recurso> {
                Recurso.Limonita(15),
                 Recurso.Hematita(10),
                Recurso.ManganesoNegro(1),
                Recurso.Tungsteno(1),

            }, cantidad, Rareza.Epico, "");
        }

        public static readonly string TCobreRefinado = "Cobre refinado";
        public static Material CobreRefinado(int cantidad)
        {
            return new Material(TCobreRefinado, 20, new List<Recurso> {
                Recurso.Digenita(15),
                 Recurso.Cuprita(10),
                Recurso.Carbon(1),
                Recurso.Minio(1),

            }, cantidad, Rareza.Epico, "");
        }

        public static readonly string TCobrePuro = "Cobre puro";
        public static Material CobrePuro(int cantidad)
        {
            return new Material(TCobrePuro, 20, new List<Recurso> {
                Recurso.Digenita(15),
                 Recurso.Cuprita(10),
                Recurso.Alumbre(1),
                Recurso.Fosforo(1),

            }, cantidad, Rareza.Epico, "");
        }

        public static readonly string TCuerogHervido = "Cuero hervido";
        public static Material CueroHervido(int cantidad)
        {
            return new Material(TCuerogHervido, 20, new List<Recurso> {
                Recurso.Cabra(15),
                 Recurso.Vaca(10),
                Recurso.NitratoPotasio(1),
                Recurso.PelajeLoboMontaña(1),

            }, cantidad, Rareza.Epico, "");
        }

        public static readonly string TPiedraPerfeccionada = "Piedra perfeccionada";
        public static Material PiedraPerfeccionada(int cantidad)
        {
            return new Material(TPiedraPerfeccionada, 20, new List<Recurso> {
                Recurso.Marmol(15),
                 Recurso.Granito(10),              

            }, cantidad, Rareza.Epico, "");
        }

        public static readonly string TPiedraDetallada = "Piedra detallada";
        public static Material PiedraDetallada(int cantidad)
        {
            return new Material(TPiedraDetallada, 20, new List<Recurso> {
                Recurso.Marmol(15),
                 Recurso.Granito(10),

            }, cantidad, Rareza.Epico, "");
        }

    }
}
