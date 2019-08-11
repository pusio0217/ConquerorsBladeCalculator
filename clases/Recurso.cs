using Conqueros_Calculator.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Conquerors_Calculator.modelos
{
    public class Recurso:ICloneable
    {
        public enum Origen
        {
            Algodon, Hierro, Cobre, Curtiduria, Madera, Piedra
        }
        public enum Tipo
        {
         Normal,Exotico
        }

        public string descripcion
        {
            get
            {
                if (App.Current.Properties["language"].ToString() == "es")
                    return idiomaES.ResourceManager.GetString(this.nombre);
                return idiomaEN.ResourceManager.GetString(this.nombre);
            }
        }


        public Brush color
        {
            get
            {
                return Funciones.ColorFromRareza(this.rareza);
            }
            set { }
        }
        private string _imagen;
        public string imagen { get { return "images/" + _imagen; } set { _imagen = value; } }

        public string nombre { get; set; }
        public int cantidad { get; set; }
        public Rareza rareza { get; set; }
        public List<Zonas> zonas;
        public Origen origen;
        public Tipo tipo;
     

        protected Recurso(string nombre, int cantidad, Rareza rareza,Origen origen,Tipo tipo,string imagen)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.rareza = rareza;
            this.imagen = imagen;
            this.origen = origen;
            this.tipo = tipo;

        }

        public static Recurso AlgodonPocaCalidad(int cantidad)
        {
            return new Recurso(idioma.algodonPocaCalidad, cantidad, Rareza.Comun,Origen.Algodon,Tipo.Normal,"algodonPoca.PNG");
        }
        public static Recurso AlgodonCalidadMedia(int cantidad)
        {
            return new Recurso(idioma.algodonMediaCalidad, cantidad, Rareza.PocoComun,Origen.Algodon,Tipo.Normal,"algodonMedia.PNG");
        }
        public static Recurso AlgodonAltaCalidad(int cantidad)
        {
            return new Recurso(idioma.algodonAltaCalidad,cantidad, Rareza.Raro,Origen.Algodon,Tipo.Normal,"algodonAlta.PNG");
        }
        public static Recurso AlgodonMejorCalidad(int cantidad)
        {
            return new Recurso(idioma.algodonMejorCalidad, cantidad, Rareza.Epico,Origen.Algodon,Tipo.Normal,"algodonMejor.PNG");
        }
        public static Recurso AlgodonNube(int cantidad)
        {
            return new Recurso(idioma.algodonNube, cantidad, Rareza.PocoComun,Origen.Algodon,Tipo.Exotico, "algodonNube.PNG");
        }

        public static Recurso Tungsteno(int cantidad)
        {
            return new Recurso(idioma.tungsteno, cantidad, Rareza.PocoComun,Origen.Hierro,Tipo.Exotico, "tungsteno.PNG");
        }

        public static Recurso Siderita(int cantidad)
        {
            return new Recurso(idioma.siderita, cantidad, Rareza.Comun,Origen.Hierro,Tipo.Normal,"siderita.PNG");
        }
        public static Recurso Magnetita(int cantidad)
        {
            return new Recurso(idioma.magnetita, cantidad, Rareza.PocoComun,Origen.Hierro,Tipo.Normal,"magnetita.PNG");
        }
        public static Recurso Limonita(int cantidad)
        {
            return new Recurso(idioma.limonita, cantidad, Rareza.Raro,Origen.Hierro,Tipo.Normal,"limonita.PNG");
        }
        public static Recurso Hematita(int cantidad)
        {
            return new Recurso(idioma.hematita, cantidad, Rareza.Epico,Origen.Hierro,Tipo.Normal,"hematita.PNG");
        }



        public static Recurso Calcopirita(int cantidad)
        {
            return new Recurso(idioma.calcopirita, cantidad, Rareza.Comun,Origen.Cobre,Tipo.Normal,"calcopirita.PNG");
        }
        public static Recurso Calcosina(int cantidad)
        {
            return new Recurso(idioma.calcosina, cantidad, Rareza.PocoComun,Origen.Cobre,Tipo.Normal,"calcosina.PNG");
        }
        public static Recurso Digenita(int cantidad)
        {
            return new Recurso(idioma.digenita, cantidad, Rareza.Raro,Origen.Cobre,Tipo.Normal,"digenita.PNG");
        }
        public static Recurso Cuprita(int cantidad)
        {
            return new Recurso(idioma.cuprita, cantidad, Rareza.Epico,Origen.Cobre,Tipo.Normal,"cuprita.PNG");
        }

        public static Recurso Cerdo(int cantidad)
        {
            return new Recurso(idioma.cerdo, cantidad, Rareza.Comun,Origen.Curtiduria,Tipo.Normal,"pielCerdo.PNG");
        }
        public static Recurso Oveja(int cantidad)
        {
            return new Recurso(idioma.oveja, cantidad, Rareza.PocoComun,Origen.Curtiduria,Tipo.Normal,"pielOveja.PNG");
        }
        public static Recurso Cabra(int cantidad)
        {
            return new Recurso(idioma.cabra, cantidad, Rareza.Raro,Origen.Curtiduria,Tipo.Normal,"pielCabra.PNG");
        }
        public static Recurso Vaca(int cantidad)
        {
            return new Recurso(idioma.vaca, cantidad, Rareza.Epico,Origen.Curtiduria,Tipo.Normal,"pielVaca.PNG");
        }



        public static Recurso Pino(int cantidad)
        {
            return new Recurso(idioma.pino, cantidad, Rareza.Comun,Origen.Madera,Tipo.Normal,"maderaPino.PNG");
        }
        public static Recurso Fresno(int cantidad)
        {
            return new Recurso(idioma.fresno, cantidad, Rareza.PocoComun, Origen.Madera, Tipo.Normal,"maderaFresno.PNG");
        }
        public static Recurso Roble(int cantidad)
        {
            return new Recurso(idioma.roble, cantidad, Rareza.Raro, Origen.Madera, Tipo.Normal, "maderaRoble.PNG");
        }
        public static Recurso Cedro(int cantidad)
        {
            return new Recurso(idioma.cedro, cantidad, Rareza.Epico, Origen.Madera, Tipo.Normal, "maderaCedro.PNG");
        }


        public static Recurso Arenisca(int cantidad)
        {
            return new Recurso(idioma.arenisca, cantidad, Rareza.Comun,Origen.Piedra,Tipo.Normal,"arenisca.PNG");
        }
        public static Recurso RocaCaliza(int cantidad)
        {
            return new Recurso(idioma.rocaCaliza, cantidad, Rareza.PocoComun, Origen.Piedra, Tipo.Normal, "rocaCaliza.PNG");
        }
        public static Recurso Marmol(int cantidad)
        {
            return new Recurso(idioma.marmol, cantidad, Rareza.Raro, Origen.Piedra, Tipo.Normal, "marmol.PNG");
        }
        public static Recurso Granito(int cantidad)
        {
            return new Recurso(idioma.granito, cantidad, Rareza.Epico, Origen.Piedra, Tipo.Normal, "granito.PNG");
        }



        public static Recurso Calamina(int cantidad)
        {
            return new Recurso(idioma.calamina, cantidad, Rareza.PocoComun,Origen.Cobre,Tipo.Exotico,"calamina.PNG");
        }
        public static Recurso Alumbre(int cantidad)
        {
            return new Recurso(idioma.alumbre, cantidad, Rareza.PocoComun,Origen.Cobre,Tipo.Exotico,"alumbre.PNG");
        }
        public static Recurso ManganesoNegro(int cantidad)
        {
            return new Recurso(idioma.manganesoNegro, cantidad, Rareza.PocoComun, Origen.Hierro, Tipo.Exotico, "manganesoNegro.PNG");
        }
        public static Recurso Estaño(int cantidad)
        {
            return new Recurso(idioma.estaño, cantidad, Rareza.PocoComun,Origen.Hierro,Tipo.Exotico ,"estaño.PNG");
        }

        public static Recurso Minio(int cantidad)
        {
            return new Recurso(idioma.minio, cantidad, Rareza.Raro,Origen.Cobre,Tipo.Exotico,"minio.PNG");
        }

        public static Recurso BauxitaMontaña(int cantidad)
        {
            return new Recurso(idioma.bauxitamontaña, cantidad, Rareza.Epico,Origen.Hierro,Tipo.Exotico,"bauxita.PNG");
        }
        public static Recurso Fosforo(int cantidad)
        {
            return new Recurso(idioma.fosforo, cantidad, Rareza.Epico,Origen.Cobre,Tipo.Exotico,"fosforo.PNG");
        }
        public static Recurso Granate(int cantidad)
        {
            return new Recurso(idioma.granate, cantidad, Rareza.Epico,Origen.Hierro,Tipo.Exotico,"");
        }
        public static Recurso Turquesa(int cantidad)
        {
            return new Recurso(idioma.turquesa, cantidad, Rareza.Epico,Origen.Cobre,Tipo.Exotico,"");
        }

        public static Recurso Tendones(int cantidad)
        {
            return new Recurso(idioma.tendones, cantidad, Rareza.PocoComun,Origen.Curtiduria,Tipo.Exotico,"tendones.PNG");
        }

        public static Recurso Pelajes(int cantidad)
        {
            return new Recurso(idioma.pelajes, cantidad, Rareza.PocoComun,Origen.Curtiduria,Tipo.Exotico,"pelajes.PNG");
        }

        public static Recurso PielBisonte(int cantidad)
        {
            return new Recurso(idioma.pielbisonte, cantidad, Rareza.Raro,Origen.Curtiduria,Tipo.Exotico,"pielBisonte.PNG");
        }

        public static Recurso PelajeLoboMontaña(int cantidad)
        {
            return new Recurso(idioma.pelajelobomontaña, cantidad, Rareza.Epico,Origen.Curtiduria,Tipo.Exotico,"pelajeLoboMontaña.PNG");
        }

        public static Recurso Almizcle(int cantidad)
        {
            return new Recurso(idioma.almizcle, cantidad, Rareza.Epico,Origen.Curtiduria,Tipo.Exotico,"");
        }

        public static Recurso NitratoPotasio(int cantidad)
        {
            return new Recurso(idioma.nitratopotasio, cantidad, Rareza.PocoComun,Origen.Piedra,Tipo.Exotico,"nitratoPotasio.PNG");
        }
        public static Recurso Carbon(int cantidad)
        {
            return new Recurso(idioma.carbon, cantidad, Rareza.PocoComun,Origen.Piedra,Tipo.Exotico,"carbon.PNG");
        }
        public static Recurso PiedraLunar(int cantidad)
        {
            return new Recurso(idioma.piedralunar, cantidad, Rareza.Epico,Origen.Piedra,Tipo.Exotico,"");
        }

        public static Recurso AceiteLinaza(int cantidad)
        {
            return new Recurso(idioma.aceitelinaza, cantidad, Rareza.PocoComun,Origen.Madera,Tipo.Exotico,"");
        }
        public static Recurso GomaLaca(int cantidad)
        {
            return new Recurso(idioma.gomalaca, cantidad, Rareza.PocoComun,Origen.Madera,Tipo.Exotico,"gomaLaca.PNG");
        }
        public static Recurso Tejo(int cantidad)
        {
            return new Recurso(idioma.tejo, cantidad, Rareza.Raro,Origen.Madera,Tipo.Exotico,"tejo.PNG");
        }
      
        public static Recurso Ambar(int cantidad)
        {
            return new Recurso(idioma.ambar, cantidad, Rareza.Epico,Origen.Madera,Tipo.Exotico,"");
        }

        public static Recurso Lino(int cantidad)
        {
            return new Recurso(idioma.lino, cantidad, Rareza.PocoComun,Origen.Algodon,Tipo.Exotico,"lino.PNG");
        }
        public static Recurso Cañamo(int cantidad)
        {
            return new Recurso(idioma.cañamo, cantidad, Rareza.PocoComun,Origen.Algodon,Tipo.Exotico,"cañamo.PNG");
        }
        public static Recurso AlgodonMontaña(int cantidad)
        {
            return new Recurso(idioma.algodonMontaña, cantidad, Rareza.Epico,Origen.Algodon, Tipo.Exotico,"algodonMontaña.PNG");
        }
        public static Recurso Seda(int cantidad)
        {
            return new Recurso(idioma.seda, cantidad, Rareza.Epico,Origen.Algodon,Tipo.Exotico,"");
        }

        public object Clone()
        {
       
                return this.MemberwiseClone();         
        }
    }
}
