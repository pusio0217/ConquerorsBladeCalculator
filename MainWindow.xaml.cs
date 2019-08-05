using Conqueros_Calculator.modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


        public List<Equipamiento> myEquipamientos;// { new EquipamientoCantidad { equipamiento = lanceroSeñorio, cantidad = 3 } };

        public MainWindow()
        {
            InitializeComponent();

            myEquipamientos = new List<Equipamiento>();

        }


        private void MuestraMateriales()
        {




          /*  txtCueroCurtido.Text = myEquipamientos.Sum(x => x.cantidad * (x.materiales.Where(z => z.nombre == Material.TCueroCurtido).Sum(y => y.cantidad))).ToString("N0");
            txtHierroBruto.Text = myEquipamientos.Sum(x => x.cantidad * (x.materiales.Where(z => z.nombre == Material.THierroBruto).Sum(y => y.cantidad))).ToString("N0");
            txtTelaAspera.Text = myEquipamientos.Sum(x => x.cantidad * (x.materiales.Where(z => z.nombre == Material.TTelaAspera).Sum(y => y.cantidad))).ToString("N0");
            txtMaderaSeca.Text = myEquipamientos.Sum(x => x.cantidad * (x.materiales.Where(z => z.nombre == Material.TMaderaSeca).Sum(y => y.cantidad))).ToString("N0");
            txtCobreBruto.Text = myEquipamientos.Sum(x => x.cantidad * (x.materiales.Where(z => z.nombre == Material.TCobreBruto).Sum(y => y.cantidad))).ToString("N0");
            */
          

            var miRecursos = new List<Recurso>();
            var miMateriales = new List<Material>();




            foreach (var myEquipamiento in myEquipamientos.AsReadOnly())
                foreach (var myMaterial in myEquipamiento.materiales.AsReadOnly())
                {
                    var indiceMaterial=miMateriales.FindIndex(x=>x==myMaterial);
                    if(indiceMaterial!=-1)
                        miMateriales[indiceMaterial].cantidad += myEquipamiento.cantidad * myMaterial.cantidad ;
                    else
                    {
                        var MaterialAux = (Material)myMaterial.Clone();
                        MaterialAux.cantidad *= myEquipamiento.cantidad;
                        miMateriales.Add(MaterialAux);
                    }
                   foreach (var myRecurso in myMaterial.recursos)
                    {

                        var indice = miRecursos.FindIndex(x=>x.nombre==myRecurso.nombre);
                        if (indice != -1)
                            miRecursos[indice].cantidad += myEquipamiento.cantidad* myMaterial.cantidad * myRecurso.cantidad;
                        else
                        {
                            var myRecursoAux = (Recurso)myRecurso.Clone();
                            myRecursoAux.cantidad =  myMaterial.cantidad*myRecurso.cantidad*myEquipamiento.cantidad;
                            miRecursos.Add(myRecursoAux);
                        }
                    }
                }
            DGRecursos.ItemsSource = null;
            DGmateriales.ItemsSource = null;

           DGRecursos.ItemsSource = miRecursos.Where(x=>x.cantidad>0);
            DGmateriales.ItemsSource = miMateriales.Where(x => x.cantidad > 0); 

        }

        private void TxtLanceroSeñorio_TextChanged(object sender, TextChangedEventArgs e)
        {
            Debug.WriteLine("CHANGED");
            ActualizarListado((TextBox)sender, Equipamiento.LanceroSeñorio(0));
        }


        private void ActualizarListado(TextBox myTextBox, Equipamiento myEquipamiento)
        {


            try
            {

                if (!Int16.TryParse(myTextBox.Text, out Int16 cantidadEquipo))
                    cantidadEquipo = 0;

//Borro el equipamiento y borro los recursos
                myEquipamientos.RemoveAll(x => x == myEquipamiento);


                var myNewEquipamiento = myEquipamiento;
                myNewEquipamiento.cantidad = cantidadEquipo;
                myEquipamientos.Add(myNewEquipamiento);
               // Debug.WriteLine("mETO:" + cantidadEquipo);

                MuestraMateriales();

            }
            catch (Exception er)
            {
               /* myTextBox.Text = "0";
                myTextBox.Background = Brushes.LightCoral;
                Debug.WriteLine(er.Message);*/

            }
        }

        private void TxtJabalineroSeñorio_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.JabalineroSeñorio(0));
        }

        private void TxtArqueroSeñorio_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.ArqueroSeñorio(0));
        }

        private void TxtBallesteroSeñorio_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.BallesteroSeñorio(0));
        }

        private void TxtCoustilleux_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.Costilleux(0));

        }



        private void ChkOcultarNoUsados_Click(object sender, RoutedEventArgs e)
        {
            MuestraMateriales();
        }

        private void TxtEscudero_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.Escudero(0));
        }

        private void TxtAlabardero_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.Alabardero(0));
        }

        private void TxtArqueroFuego_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.ArqueroDeFuego(0));
        }

        private void TxtBallesteroMercenario_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.BallesteroMercenario(0));
        }

        private void TxtArcabuquero_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.ArcabuceroMercenario(0));
        }
    }
}
