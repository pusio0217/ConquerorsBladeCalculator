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

            txtCueroCurtido.Text = myEquipamientos.Sum(x => x.cantidad * (x.materiales.Where(z => z.nombre == Material.TCueroCurtido).Sum(y => y.cantidad))).ToString("N0");
            txtHierroBruto.Text = myEquipamientos.Sum(x => x.cantidad * (x.materiales.Where(z => z.nombre == Material.THierroBruto).Sum(y => y.cantidad))).ToString("N0");
            txtTelaAspera.Text = myEquipamientos.Sum(x => x.cantidad * (x.materiales.Where(z => z.nombre == Material.TTelaAspera).Sum(y => y.cantidad))).ToString("N0");
            txtMaderaSeca.Text = myEquipamientos.Sum(x => x.cantidad * (x.materiales.Where(z => z.nombre == Material.TMaderaSeca).Sum(y => y.cantidad))).ToString("N0");
            txtCobreBruto.Text = myEquipamientos.Sum(x => x.cantidad * (x.materiales.Where(z => z.nombre == Material.TCobreBruto).Sum(y => y.cantidad))).ToString("N0");

          

            var miRecursos = new List<Recurso>();
            foreach (var myEquipamiento in myEquipamientos)
                foreach (var myMaterial in myEquipamiento.materiales)
                    foreach (var myRecurso in myMaterial.recursos)
                    {
                      
                        var indice = miRecursos.IndexOf(myRecurso);
                        if (indice != -1)
                            miRecursos[indice].cantidad += myEquipamiento.cantidad * myMaterial.cantidad * myRecurso.cantidad;
                        else
                        {
                            myRecurso.cantidad *= myEquipamiento.cantidad * myMaterial.cantidad;
                            miRecursos.Add(myRecurso);
                        }
                    }
            DGmateriales.ItemsSource = miRecursos.Where(x=>x.cantidad>0);

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
                    throw new Exception("mal");


                myEquipamientos.RemoveAll(x => x == myEquipamiento);

                var myNewEquipamiento = myEquipamiento;
                myNewEquipamiento.cantidad = cantidadEquipo;
                myEquipamientos.Add(myNewEquipamiento);
                Debug.WriteLine("mETO:" + cantidadEquipo);

                MuestraMateriales();

            }
            catch (Exception er)
            {
                myTextBox.Text = "0";
                myTextBox.Background = Brushes.LightCoral;
                Debug.WriteLine(er.Message);

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
    }
}
