using Conquerors_Calculator.Properties;
using Conqueros_Calculator.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Media;

namespace Conquerors_Calculator.modelos
{



 
    public class toolTipStruct
    {
        public string imagen { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public Brush color { get; set; }
    }
    public partial class Material: ICloneable
    {
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
        }
        public IEnumerable<toolTipStruct> ToolTips { get { return recursos.Select(x => new toolTipStruct { imagen = x.imagen,nombre=x.nombre,cantidad=x.cantidad*cantidad,color=Funciones.ColorFromRareza(x.rareza) ,descripcion=x.descripcion}); }  }
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
       
        public static Material TelaAspera(int cantidad)
        {
            return new Material(idioma.telaAspera, 2, new List<Recurso> {
                Recurso.AlgodonPocaCalidad(10),
                Recurso.AlgodonCalidadMedia(8),
                Recurso.AlgodonAltaCalidad(7),
                Recurso.AlgodonMejorCalidad(6)
            }, cantidad, Rareza.PocoComun,"telaAspera.PNG");
        }

    
        public static Material HierroBruto(int cantidad)
        {
            return new Material(idioma.hierroBruto, 2, new List<Recurso> {
                Recurso.Siderita(10),
                Recurso.Magnetita(8),
                Recurso.Limonita(7),
                Recurso.Hematita(6)
            }, cantidad, Rareza.PocoComun, "hierroBruto.PNG");
        }

      
        public static Material CobreBruto(int cantidad)
        {
            return new Material(idioma.cobreBruto, 2, new List<Recurso> {
                Recurso.Calcopirita(10),
                Recurso.Calcosina(8),
                Recurso.Digenita(7),
                Recurso.Cuprita(6)
            }, cantidad, Rareza.PocoComun, "cobreBruto.PNG");
        }
        
        public static Material CueroCurtido(int cantidad)
        {
            return new Material(idioma.cueroCurtido, 2, new List<Recurso> {
                Recurso.Cerdo(10),
                Recurso.Oveja(8),
                Recurso.Cabra(7),
                Recurso.Vaca(6)
            }, cantidad, Rareza.PocoComun, "cueroCurtido.PNG");
        }
      
        public static Material MaderaSeca(int cantidad)
        {
            return new Material(idioma.maderaSeca, 2, new List<Recurso> {
                Recurso.Pino(10),
                Recurso.Fresno(8),
                Recurso.Roble(7),
                Recurso.Cedro(6)
            }, cantidad, Rareza.PocoComun, "maderaSeca.PNG");
        }

      
        public static Material PiedraBruto(int cantidad)
        {
            return new Material(idioma.piedraBruto, 2, new List<Recurso> {
                Recurso.Arenisca(10),
                Recurso.RocaCaliza(8),
                Recurso.Marmol(7),
                Recurso.Granito(6)
            }, cantidad, Rareza.PocoComun, "piedraBruto.PNG");
        }
        #endregion
    
       
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        

    }
}
