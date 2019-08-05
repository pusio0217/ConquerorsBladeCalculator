using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Conqueros_Calculator.modelos
{
   
    public class Material: ICloneable
    {

        public Brush color
        {
            get
            {
                return Funciones.ColorFromRareza(this.rareza);
            }
        }
        public static bool operator ==(Material e1, Material e2)
        {
            return e1.nombre == e2.nombre;
        }
        public static bool operator !=(Material e1, Material e2)
        {
            return e1.nombre != e2.nombre;
        }

        private string _imagen;
        public string imagen { get { return "images/" + _imagen; } set { _imagen = value; }}
        public string nombre { get; set; }
        public int costePlata;
        public List<Recurso> recursos;
        public int cantidad { get; set; }
        public Rareza rareza;


        public Material(string nombre, int costePlata, List<Recurso> recursos, int cantidad, Rareza rareza,string imagen)
        {
            this.nombre = nombre;
            this.costePlata = costePlata;
            this.recursos = recursos;
            this.cantidad = cantidad;
            this.rareza = rareza;
            this.imagen = imagen;
        }


        #region comunes
        public static readonly string TTelaAspera = "Tela áspera";
        public static Material TelaAspera(int cantidad)
        {
            return new Material(TTelaAspera, 2, new List<Recurso> {
                Recurso.AlgodonPocaCalidad(10),
                Recurso.AlgodonCalidadMedia(8),
                Recurso.AlgodonAltaCalidad(7),
                Recurso.AlgodonMejorCalidad(6)
            }, cantidad, Rareza.PocoComun,"telaAspera.PNG");
        }

        public static readonly string THierroBruto = "Hierro en bruto";
        public static Material HierroBruto(int cantidad)
        {
            return new Material(THierroBruto, 2, new List<Recurso> {
                Recurso.Siderita(10),
                Recurso.Magnetita(8),
                Recurso.Limonita(7),
                Recurso.Hematita(6)
            }, cantidad, Rareza.PocoComun, "hierroBruto.PNG");
        }

        public static readonly string TCobreBruto = "Cobre en bruto";
        public static Material CobreBruto(int cantidad)
        {
            return new Material(TCobreBruto, 2, new List<Recurso> {
                Recurso.Calcopirita(10),
                Recurso.Calcosina(8),
                Recurso.Digenita(7),
                Recurso.Cuprita(6)
            }, cantidad, Rareza.PocoComun, "cobreBruto.PNG");
        }
        public static readonly string TCueroCurtido = "Cuero curtido";
        public static Material CueroCurtido(int cantidad)
        {
            return new Material(TCueroCurtido, 2, new List<Recurso> {
                Recurso.Cerdo(10),
                Recurso.Oveja(8),
                Recurso.Cabra(7),
                Recurso.Vaca(6)
            }, cantidad, Rareza.PocoComun, "cueroCurtido.PNG");
        }
        public static readonly string TMaderaSeca = "Madera seca";
        public static Material MaderaSeca(int cantidad)
        {
            return new Material(TMaderaSeca, 2, new List<Recurso> {
                Recurso.Pino(10),
                Recurso.Fresno(8),
                Recurso.Roble(7),
                Recurso.Cedro(6)
            }, cantidad, Rareza.PocoComun, "maderaSeca.PNG");
        }

        public static readonly string TPiedraBruto = "Piedra en bruto";
        public static Material PiedraBruto(int cantidad)
        {
            return new Material(TPiedraBruto, 2, new List<Recurso> {
                Recurso.Arenisca(10),
                Recurso.RocaCaliza(8),
                Recurso.Marmol(7),
                Recurso.Granito(6)
            }, cantidad, Rareza.PocoComun, "piedraBruto.PNG");
        }
        #endregion
        #region poco comunes
        public static readonly string TTelaBarata = "Tela barata";
        public static Material TelaBarata(int cantidad)
        {
            return new Material(TTelaBarata, 5, new List<Recurso> {
                Recurso.AlgodonPocaCalidad(25),
                Recurso.AlgodonCalidadMedia(10),
                Recurso.AlgodonAltaCalidad(8),
                Recurso.AlgodonMejorCalidad(7),
                Recurso.Lino(1)

            }, cantidad, Rareza.Raro, "telaBarata.PNG");
        }

        public static readonly string THierroFundido = "Hierro Fundido";
        public static Material HierroFundido(int cantidad)
        {
            return new Material(THierroFundido, 5, new List<Recurso> {
                Recurso.Siderita(25),
                Recurso.Magnetita(10),
                Recurso.Limonita(8),
                Recurso.Hematita(7),
                Recurso.Calamina(1)

            }, cantidad, Rareza.Raro, "hierroFundido.PNG");
        }

        public static readonly string TCobreMejorado = "Cobre mejorado";
        public static Material CobreMejorado(int cantidad)
        {
            return new Material(TCobreMejorado, 5, new List<Recurso> {
                Recurso.Calcopirita(25),
                Recurso.Calcosina(10),
                Recurso.Digenita(8),
                Recurso.Cuprita(7),
                Recurso.Estaño(1)

            }, cantidad, Rareza.Raro, "cobreMejorado.PNG");
        }
        public static readonly string TCueroTratado = "Cuero tratado";
        public static Material CueroTratado(int cantidad)
        {
            return new Material(TCueroTratado, 5, new List<Recurso> {
                Recurso.Cerdo(25),
                Recurso.Oveja(10),
                Recurso.Cabra(8),
                Recurso.Vaca(7),
                Recurso.GomaLaca(1)

            }, cantidad, Rareza.Raro, "cueroTratado.PNG");
        }

        public static readonly string TMaderaAlisada = "Madera Alisada";
        public static Material MaderaAlisada(int cantidad)
        {
            return new Material(TMaderaAlisada, 5, new List<Recurso> {
                Recurso.Pino(25),
                Recurso.Fresno(10),
                Recurso.Roble(8),
                Recurso.Cedro(7),
                Recurso.Tendones(1)

            }, cantidad, Rareza.Raro, "maderaAlisada.PNG");
        }

        public static readonly string TPiedraCortada = "Piedra cortada";
        public static Material PiedraCortada(int cantidad)
        {
            return new Material(TPiedraCortada, 5, new List<Recurso> {
                Recurso.Arenisca(25),
                Recurso.RocaCaliza(10),
                Recurso.Marmol(8),
                Recurso.Granito(7),
               
            }, cantidad, Rareza.Raro, "piedraCortada.PNG");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion

    }
}
