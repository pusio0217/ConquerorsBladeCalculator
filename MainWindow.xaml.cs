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
        static readonly Material MaderaSeca = new Material { nombre = "Madera seca" };
        static readonly Material CobreBruto = new Material { nombre = "Cobre en bruto" };

        List<EquipamientoCantidad> myEquipamientos = new List<EquipamientoCantidad>();// { new EquipamientoCantidad { equipamiento = lanceroSeñorio, cantidad = 3 } };


        protected Equipamiento lanceroSeñorio = new Equipamiento
        {
            nombre = "Lancero de señorio",
            costePlata=25,
            materiales = new List<MaterialGasto> {
                new MaterialGasto { cantidad = 15, material = TelaAspera },
                 new MaterialGasto { cantidad = 15, material = CueroCurtado },
                  new MaterialGasto { cantidad = 5, material = HierroBruto },
            }
        };

        protected Equipamiento jabalineroSeñorio = new Equipamiento
        {
            nombre = "Jabalinero de señorio",
            costePlata = 25,
            materiales = new List<MaterialGasto> {
                new MaterialGasto { cantidad = 15, material = MaderaSeca },
                 new MaterialGasto { cantidad = 15, material = HierroBruto },
                  new MaterialGasto { cantidad = 10, material = CueroCurtado },
            }
        };
        protected Equipamiento arqueroSeñorio = new Equipamiento
        {
            nombre = "Arqueros de señorio",
            costePlata = 25,
            materiales = new List<MaterialGasto> {
                new MaterialGasto { cantidad = 15, material = MaderaSeca },
                 new MaterialGasto { cantidad = 10, material = CobreBruto },
                  new MaterialGasto { cantidad = 10, material = TelaAspera },
            }
        };
        protected Equipamiento ballesteroSeñorio = new Equipamiento
        {
            nombre = "Ballestero de señorio",
            costePlata = 25,
            materiales = new List<MaterialGasto> {
                new MaterialGasto { cantidad = 15, material = MaderaSeca },
                 new MaterialGasto { cantidad = 15, material = TelaAspera },
                  new MaterialGasto { cantidad = 15, material = CobreBruto },
            }
        };
        protected Equipamiento coustilleux = new Equipamiento
        {
            nombre = "Coustilleux",
            costePlata = 25,
            materiales = new List<MaterialGasto> {
                new MaterialGasto { cantidad = 30, material = HierroBruto },
                 new MaterialGasto { cantidad = 20, material = MaderaSeca },
                  new MaterialGasto { cantidad = 20, material = CueroCurtado },
            }
        };

        public class EquipamientoCantidad
        {
            public Equipamiento equipamiento;
            public int cantidad;
        }


        public string toolTip(Equipamiento myEquipamiento) {
            return myEquipamiento.nombre + Environment.NewLine+string.Join(Environment.NewLine, myEquipamiento.materiales.Select(x => x.cantidad + " " + x.material.nombre));
        } 
        public MainWindow()
        {
            InitializeComponent();

            imgLanceroSeñorio.ToolTip = toolTip(lanceroSeñorio);
            imgJabalineroSeñorio.ToolTip = toolTip(jabalineroSeñorio);
            imgArqueroSeñorio.ToolTip = toolTip(arqueroSeñorio);
            imgBallesteroSeñorio.ToolTip = toolTip(ballesteroSeñorio);
            imgCoustilleux.ToolTip = toolTip(coustilleux);
           

        }

        private void muestraRecursos()
        {
            txtCueroCurtado.Text = myEquipamientos.Sum(x => x.cantidad * x.equipamiento.materiales.Where(z => z.material == CueroCurtado).Sum(y => y.cantidad)).ToString("N0");
            ((Grid)txtCueroCurtado.Parent).Visibility = txtCueroCurtado.Text == "0" && chkOcultarNoUsados.IsChecked.Value? Visibility.Collapsed : Visibility.Visible; 
            txtHierroBruto.Text = myEquipamientos.Sum(x => x.cantidad * x.equipamiento.materiales.Where(z => z.material == HierroBruto).Sum(y => y.cantidad)).ToString("N0");
            ((Grid)txtHierroBruto.Parent).Visibility = txtHierroBruto.Text == "0" && chkOcultarNoUsados.IsChecked.Value ? Visibility.Collapsed : Visibility.Visible;
            txtTelaAspera.Text = myEquipamientos.Sum(x => x.cantidad * x.equipamiento.materiales.Where(z => z.material == TelaAspera).Sum(y => y.cantidad)).ToString("N0");
            ((Grid)txtTelaAspera.Parent).Visibility = txtTelaAspera.Text == "0" && chkOcultarNoUsados.IsChecked.Value ? Visibility.Collapsed : Visibility.Visible;
            txtMaderaSeca.Text = myEquipamientos.Sum(x => x.cantidad * x.equipamiento.materiales.Where(z => z.material == MaderaSeca).Sum(y => y.cantidad)).ToString("N0");
            ((Grid)txtMaderaSeca.Parent).Visibility = txtMaderaSeca.Text == "0" && chkOcultarNoUsados.IsChecked.Value ? Visibility.Collapsed : Visibility.Visible;
            txtCobreBruto.Text = myEquipamientos.Sum(x => x.cantidad * x.equipamiento.materiales.Where(z => z.material == CobreBruto).Sum(y => y.cantidad)).ToString("N0");
            ((Grid)txtCobreBruto.Parent).Visibility = txtCobreBruto.Text == "0" && chkOcultarNoUsados.IsChecked.Value ? Visibility.Collapsed : Visibility.Visible;
            txtPlata.Text = myEquipamientos.Sum(x => x.cantidad * x.equipamiento.costePlata).ToString("N0");
        }


        private void TxtLanceroSeñorio_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, lanceroSeñorio);
        }


        private void ActualizarListado(TextBox myTextBox, Equipamiento myEquipamiento)
        {


            try
            {
                txtLanceroSeñorio.Background = Brushes.White;
                if (!Int16.TryParse(myTextBox.Text, out Int16 cantidadEquipo))
                    throw new Exception("Lanceros señorios invalidos");


                myEquipamientos.RemoveAll(x => x.equipamiento == myEquipamiento);

                var myNewEquipamiento = new EquipamientoCantidad { cantidad = cantidadEquipo, equipamiento = myEquipamiento };
                myEquipamientos.Add(myNewEquipamiento);
                muestraRecursos();

            }
            catch (Exception er)
            {
                myTextBox.Text = "0";
                myTextBox.Background = Brushes.LightCoral;

            }
        }

        private void TxtJabalineroSeñorio_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, jabalineroSeñorio);
        }

        private void TxtArqueroSeñorio_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, arqueroSeñorio);
        }

        private void TxtBallesteroSeñorio_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, ballesteroSeñorio);
        }

        private void TxtCoustilleux_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, coustilleux);

        }

        private void TxtLanceroSeñorio_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txtLanceroSeñorio.SelectAll();
        }

        private void TxtLanceroSeñorio_GotMouseCapture(object sender, MouseEventArgs e)
        {
            txtLanceroSeñorio.SelectAll();
        }

        private void ChkOcultarNoUsados_Click(object sender, RoutedEventArgs e)
        {
            muestraRecursos();
        }
    }
}
