using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conqueros_Calculator.modelos
{
    public class Recurso
    {
        public enum Origen
        {
            Algodon, Hierro, Cobre, Piel, Madera, Piedra
        }

        #region nombres
        /// <summary>
        /// Algodones
        /// </summary>
        public readonly static string TAlgodonPocaCalidad = "Algodon poca calidad";
        public readonly static string TAlgodonMediaCalidad = "Algodon media calidad";
        public readonly static string TAlgodonAltaCalidad = "Algodon alta calidad";
        public readonly static string TAlgodonMejorCalidad = "Algodon mejor calidad";

        /// <summary>
        /// Hierro
        /// </summary>
        public readonly static string THierroSiderita = "Siderita";
        public readonly static string THierroMagnetita = "Magnetita";
        public readonly static string THierroLimonita = "Limonita";
        public readonly static string THierroHematita = "Hematita";

        /// <summary>
        /// Cobre
        /// </summary>
        public readonly static string TCobreCalcopirita = "Calcopirita";
        public readonly static string TCobreCalcosina = "Calcosina";
        public readonly static string TCobreDigenita = "Digenita";
        public readonly static string TCobreCuprita = "Cuprita";

        /// <summary>
        /// Pieles
        /// </summary>
        public readonly static string TPielDeCerdo = "Cerdo";
        public readonly static string TPielOveja = "Oveja";
        public readonly static string TPielCabra = "Cabra";
        public readonly static string TPielVaca = "Vaca";

        /// <summary>
        /// Madera
        /// </summary>
        public readonly static string TMaderaDePino = "Pino";
        public readonly static string TMaderaDeFresno = "Fresno";
        public readonly static string TMaderaDeRoble = "Roble";
        public readonly static string TMaderaCedro = "Cedro";

        public readonly static string TPiedraArenisca = "Arenisca";
        public readonly static string TPiedraRocaCaliza = "Caliza";
        public readonly static string TPiedraMarmol = "Mármol";
        public readonly static string TPiedraGranito = "Granito";


        public readonly static string TCalamina = "Calamina";
        public readonly static string TAlumbre = "Alumbre";
        public readonly static string TManganesoNegro = "Manganeso negro";
        public readonly static string TEstaño = "Estaño";

        public readonly static string TMinio = "Minio";
        public readonly static string TBauxitaMontaña = "Bauxita de montaña";
        public readonly static string TFosforo = "Fosforo";
        public readonly static string TGranate = "Granate";
        public readonly static string TTurquesa = "Turquesa";

        public readonly static string TTendones = "Tendones";
        public readonly static string TPelajes= "Pelajes";
        public readonly static string TPielBisonte = "Piel de bisonte";
        public readonly static string TPelajeLoboMontaña = "Pelaje lobo montaña";
        public readonly static string TAlmizcle = "Almizcle";

        public readonly static string TNitratoPotasio = "Nitrato de potasio";
        public readonly static string TCarbon = "Carbón";
        public readonly static string TPiedraLunar = "Piedra lunar";

        public readonly static string TAceiteLinaza = "Aceite linaza";
        public readonly static string TGomaLaca = "Goma laca";
        public readonly static string TTejo = "Tejo";
        public readonly static string TAlerce = "Alerce";
        public readonly static string TAmbar = "Ambar";

        public readonly static string TLino = "Lino";
        public readonly static string TCañamo = "Cañamo";
        public readonly static string TAlgodonMontaña = "Algodón de montaña";
        public readonly static string TSeda = "Seda";


        #endregion
        public string nombre;
        public int cantidad;
        public Rareza rareza;
        public List<Zonas> zonas;
        public Origen origen;

        protected Recurso(string nombre, int cantidad, Rareza rareza)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.rareza = rareza;
        }

        public static Recurso AlgodonPocaCalidad(int cantidad)
        {
            return new Recurso(TAlgodonPocaCalidad, cantidad, Rareza.Comun);
        }
        public static Recurso AlgodonCalidadMedia(int cantidad)
        {
            return new Recurso(TAlgodonMediaCalidad, cantidad, Rareza.PocoComun);
        }
        public static Recurso AlgodonAltaCalidad(int cantidad)
        {
            return new Recurso(TAlgodonAltaCalidad, cantidad, Rareza.Raro);
        }
        public static Recurso AlgodonMejorCalidad(int cantidad)
        {
            return new Recurso(TAlgodonMejorCalidad, cantidad, Rareza.Epico);
        }


        public static Recurso Siderita(int cantidad)
        {
            return new Recurso(THierroSiderita, cantidad, Rareza.Comun);
        }
        public static Recurso Magnetita(int cantidad)
        {
            return new Recurso(THierroMagnetita, cantidad, Rareza.PocoComun);
        }
        public static Recurso Limonita(int cantidad)
        {
            return new Recurso(THierroLimonita, cantidad, Rareza.Raro);
        }
        public static Recurso Hematita(int cantidad)
        {
            return new Recurso(THierroHematita, cantidad, Rareza.Epico);
        }



        public static Recurso Calcopirita(int cantidad)
        {
            return new Recurso(TCobreCalcopirita, cantidad, Rareza.Comun);
        }
        public static Recurso Calcosina(int cantidad)
        {
            return new Recurso(TCobreCalcosina, cantidad, Rareza.PocoComun);
        }
        public static Recurso Digenita(int cantidad)
        {
            return new Recurso(TCobreDigenita, cantidad, Rareza.Raro);
        }
        public static Recurso Cuprita(int cantidad)
        {
            return new Recurso(TCobreCuprita, cantidad, Rareza.Epico);
        }

        public static Recurso Cerdo(int cantidad)
        {
            return new Recurso(TPielDeCerdo, cantidad, Rareza.Comun);
        }
        public static Recurso Oveja(int cantidad)
        {
            return new Recurso(TPielOveja, cantidad, Rareza.PocoComun);
        }
        public static Recurso Cabra(int cantidad)
        {
            return new Recurso(TPielCabra, cantidad, Rareza.Raro);
        }
        public static Recurso Vaca(int cantidad)
        {
            return new Recurso(TPielVaca, cantidad, Rareza.Epico);
        }



        public static Recurso Pino(int cantidad)
        {
            return new Recurso(TMaderaDePino, cantidad, Rareza.Comun);
        }
        public static Recurso Fresno(int cantidad)
        {
            return new Recurso(TMaderaDeFresno, cantidad, Rareza.PocoComun);
        }
        public static Recurso Roble(int cantidad)
        {
            return new Recurso(TMaderaDeRoble, cantidad, Rareza.Raro);
        }
        public static Recurso Cedro(int cantidad)
        {
            return new Recurso(TMaderaCedro, cantidad, Rareza.Epico);
        }


        public static Recurso Arenisca(int cantidad)
        {
            return new Recurso(TPiedraArenisca, cantidad, Rareza.Comun);
        }
        public static Recurso RocaCaliza(int cantidad)
        {
            return new Recurso(TPiedraRocaCaliza, cantidad, Rareza.PocoComun);
        }
        public static Recurso Marmol(int cantidad)
        {
            return new Recurso(TPiedraMarmol, cantidad, Rareza.Raro);
        }
        public static Recurso Granito(int cantidad)
        {
            return new Recurso(TPiedraGranito, cantidad, Rareza.Epico);
        }



        public static Recurso Calamina(int cantidad)
        {
            return new Recurso(TCalamina, cantidad, Rareza.PocoComun);
        }
        public static Recurso Alumbre(int cantidad)
        {
            return new Recurso(TAlumbre, cantidad, Rareza.PocoComun);
        }
        public static Recurso ManganesoNegro(int cantidad)
        {
            return new Recurso(TManganesoNegro, cantidad, Rareza.PocoComun);
        }
        public static Recurso Estaño(int cantidad)
        {
            return new Recurso(TEstaño, cantidad, Rareza.PocoComun);
        }

        public static Recurso Minio(int cantidad)
        {
            return new Recurso(TMinio, cantidad, Rareza.Raro);
        }

        public static Recurso BauxitaMontaña(int cantidad)
        {
            return new Recurso(TBauxitaMontaña, cantidad, Rareza.Epico);
        }
        public static Recurso Fosforo(int cantidad)
        {
            return new Recurso(TFosforo, cantidad, Rareza.Epico);
        }
        public static Recurso Granate(int cantidad)
        {
            return new Recurso(TGranate, cantidad, Rareza.Epico);
        }
        public static Recurso Turquesa(int cantidad)
        {
            return new Recurso(TTurquesa, cantidad, Rareza.Epico);
        }

        public static Recurso Tendones(int cantidad)
        {
            return new Recurso(TTendones, cantidad, Rareza.PocoComun);
        }

        public static Recurso Pelajes(int cantidad)
        {
            return new Recurso(TPelajes, cantidad, Rareza.PocoComun);
        }

        public static Recurso PielBisonte(int cantidad)
        {
            return new Recurso(TPielBisonte, cantidad, Rareza.Raro);
        }

        public static Recurso PelajeLoboMontaña(int cantidad)
        {
            return new Recurso(TPelajeLoboMontaña, cantidad, Rareza.Epico);
        }

        public static Recurso Almizcle(int cantidad)
        {
            return new Recurso(TAlmizcle, cantidad, Rareza.Epico);
        }

        public static Recurso NitratoPotasio(int cantidad)
        {
            return new Recurso(TNitratoPotasio, cantidad, Rareza.PocoComun);
        }
        public static Recurso Carbon(int cantidad)
        {
            return new Recurso(TCarbon, cantidad, Rareza.PocoComun);
        }
        public static Recurso PiedraLunar(int cantidad)
        {
            return new Recurso(TPiedraLunar, cantidad, Rareza.Epico);
        }

        public static Recurso AceiteLinaza(int cantidad)
        {
            return new Recurso(TAceiteLinaza, cantidad, Rareza.PocoComun);
        }
        public static Recurso GomaLaca(int cantidad)
        {
            return new Recurso(TGomaLaca, cantidad, Rareza.PocoComun);
        }
        public static Recurso Tejo(int cantidad)
        {
            return new Recurso(TTejo, cantidad, Rareza.Raro);
        }
        public static Recurso Alerce(int cantidad)
        {
            return new Recurso(TAlerce, cantidad, Rareza.Raro);
        }

        public static Recurso Ambar(int cantidad)
        {
            return new Recurso(TAmbar, cantidad, Rareza.Epico);
        }

        public static Recurso Lino(int cantidad)
        {
            return new Recurso(TLino, cantidad, Rareza.PocoComun);
        }
        public static Recurso Cañamo(int cantidad)
        {
            return new Recurso(TCañamo, cantidad, Rareza.PocoComun);
        }
        public static Recurso AlgodonMontaña(int cantidad)
        {
            return new Recurso(TAlgodonMontaña, cantidad, Rareza.Epico);
        }
        public static Recurso Seda(int cantidad)
        {
            return new Recurso(TSeda, cantidad, Rareza.Epico);
        }
    }
}
