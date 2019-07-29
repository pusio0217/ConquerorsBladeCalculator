using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Conqueros_Calculator
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Algodones
        /// </summary>
        protected Recurso AlgodonPocaCalidad = new Recurso(NombreMaterial.AlgodonPocaCalidad, NivelRareza.Comun);
        protected Recurso AlgodonMediaCalidad = new Recurso(NombreMaterial.AlgodonMediaCalidad, NivelRareza.PocoComun);
        protected Recurso AlgodonAltaCalidad = new Recurso(NombreMaterial.AlgodonAltaCalidad, NivelRareza.Raro);
        protected Recurso AlgodonMejorCalidad = new Recurso(NombreMaterial.AlgodonMejorCalidad, NivelRareza.Epico);

        /// <summary>
        /// Hierro
        /// </summary>
        protected Recurso HierroSiderita = new Recurso(NombreMaterial.HierroSiderita, NivelRareza.Comun);
        protected Recurso HierroMagnetita = new Recurso(NombreMaterial.HierroMagnetita, NivelRareza.PocoComun);
        protected Recurso HierroLimonita = new Recurso(NombreMaterial.HierroLimonita, NivelRareza.Raro);
        protected Recurso HierroHematita = new Recurso(NombreMaterial.HierroHematita, NivelRareza.Epico);

        /// <summary>
        /// Cobre
        /// </summary>
        protected Recurso CobreCalcopirita = new Recurso(NombreMaterial.CobreCalcopirita, NivelRareza.Comun);
        protected Recurso CobreCalcosina = new Recurso(NombreMaterial.CobreCalcosina, NivelRareza.PocoComun);
        protected Recurso CobreDigenita = new Recurso(NombreMaterial.CobreDigenita, NivelRareza.Raro);
        protected Recurso CobreCuprita = new Recurso(NombreMaterial.CobreCuprita, NivelRareza.Epico);

        /// <summary>
        /// Piel
        /// </summary>
        protected Recurso PielCerdo = new Recurso(NombreMaterial.PielDeCerdo, NivelRareza.Comun);
        protected Recurso PielOveja = new Recurso(NombreMaterial.PielOveja, NivelRareza.PocoComun);
        protected Recurso PielCabra = new Recurso(NombreMaterial.PielCabra, NivelRareza.Raro);
        protected Recurso PielVaca = new Recurso(NombreMaterial.PielVaca, NivelRareza.Epico);


        /// <summary>
        /// Madera
        /// </summary>
        protected Recurso MaderaPino = new Recurso(NombreMaterial.MaderaDePino, NivelRareza.Comun);
        protected Recurso MaderaFresno = new Recurso(NombreMaterial.MaderaDeFresno, NivelRareza.PocoComun);
        protected Recurso MaderaRoble = new Recurso(NombreMaterial.MaderaDeRoble, NivelRareza.Raro);
        protected Recurso MaderaCedro = new Recurso(NombreMaterial.MaderaCedro, NivelRareza.Epico);

        /// <summary>
        /// Piedra
        /// </summary>
        static readonly Recurso PiedraArenista = new Recurso(NombreMaterial.PiedraArenisca, NivelRareza.Comun);
        static readonly Recurso PiedraRocaCaliza = new Recurso(NombreMaterial.PiedraRocaCaliza, NivelRareza.PocoComun);
        static readonly Recurso PiedraMarmol = new Recurso(NombreMaterial.PiedraMarmol, NivelRareza.Raro);
        static readonly Recurso PiedraGranito = new Recurso(NombreMaterial.PiedraGranita, NivelRareza.Epico);



        static readonly Material TelaAspera = new Material { nombre = "Tela aspera" };
        static readonly Material CueroCurtado = new Material { nombre = "Cuero Curtado" };
        static readonly Material HierroBruto = new Material { nombre = "Hierro en bruto" };



        protected Equipamiento lanceroSeñorio = new Equipamiento
        {
            nombre = "Lancero de señorio",
            materiales = new List<MaterialGasto> {
                new MaterialGasto { cantidad = 15, material = TelaAspera },
                 new MaterialGasto { cantidad = 15, material = CueroCurtado },
                  new MaterialGasto { cantidad = 5, material = HierroBruto },
            }
        };


        public class EquipamientoCantidad {
            public Equipamiento equipamiento;
            public int cantidad;
        }

        public MainWindow()
        {
            InitializeComponent();
            var myEquipamientos = new List<EquipamientoCantidad> { new EquipamientoCantidad { equipamiento = lanceroSeñorio, cantidad = 3 } };



            foreach (var myEquipamiento in myEquipamientos)
            {
                Debug.WriteLine(string.Join(", ", myEquipamiento.equipamiento.materiales.Select(x => "Cantidad:" + (x.cantidad * myEquipamiento.cantidad) + x.material.nombre)));
                
            }
            




        }



    }
}
