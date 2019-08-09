﻿using Conquerors_Calculator.modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Conquerors_Calculator
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ICollectionView cv;
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
                    var indiceMaterial = miMateriales.FindIndex(x => x == myMaterial);
                    if (indiceMaterial != -1)
                        miMateriales[indiceMaterial].cantidad += myEquipamiento.cantidad * myMaterial.cantidad;
                    else
                    {
                        var MaterialAux = (Material)myMaterial.Clone();
                        MaterialAux.cantidad *= myEquipamiento.cantidad;
                        miMateriales.Add(MaterialAux);
                    }
                    foreach (var myRecurso in myMaterial.recursos)
                    {

                        var indice = miRecursos.FindIndex(x => x.nombre == myRecurso.nombre);
                        if (indice != -1)
                            miRecursos[indice].cantidad += myEquipamiento.cantidad * myMaterial.cantidad * myRecurso.cantidad;
                        else
                        {
                            var myRecursoAux = (Recurso)myRecurso.Clone();
                            myRecursoAux.cantidad = myMaterial.cantidad * myRecurso.cantidad * myEquipamiento.cantidad;
                            miRecursos.Add(myRecursoAux);
                        }
                    }
                }
            DGRecursos.ItemsSource = null;
            DGmateriales.ItemsSource = null;

            DGRecursos.ItemsSource = miRecursos.Where(x => x.cantidad > 0);
            DGmateriales.ItemsSource = miMateriales.Where(x => x.cantidad > 0);
            cv = CollectionViewSource.GetDefaultView(DGRecursos.ItemsSource);
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

        private void TxtSargentoLancero_TextChanged(object sender, TextChangedEventArgs e)
        {

            ActualizarListado((TextBox)sender, Equipamiento.SargentoLancero(0));
        }



        private void DGmateriales_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var materialesSeleccionados = DGmateriales.SelectedItems;
            if (materialesSeleccionados.Count > 1)
            {
                var recursosRojos = ((List<Material>)materialesSeleccionados).Select(x => x.recursos.Select(z => z.nombre));



            }
        }

        private void TxtHombreArmas_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.HombreDeArmas(0));
        }

        private void TxtSargentoJabalinero_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.SargentoJabalinero(0));
        }

        private void TxtSargentoAlabardero_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.SargentoAlabardero(0));
        }

        private void TxtArqueroMercenario_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.ArqueroMercenario(0));
        }

        private void TxtFusileroKriegsrat_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.FusileroKriegsrat(0));
        }

        private void TxtLanceroYeoman_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarListado((TextBox)sender, Equipamiento.LanceroYeoman(0));
        }



        private void ImgSpain_Click(object sender, RoutedEventArgs e)
        {
           
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri("Properties/es.xaml",
                     UriKind.RelativeOrAbsolute);
            this.Resources.MergedDictionaries.Add(dict);
        }




        private void ImgEnglish_Click(object sender, RoutedEventArgs e)
        {
          
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri("Properties/en.xaml",
                     UriKind.RelativeOrAbsolute);
            this.Resources.MergedDictionaries.Add(dict);
        }





        private List<Predicate<Recurso>> criteria = new List<Predicate<Recurso>>();
        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {

            Filtrar();
        }



        private void Filtrar() {
            cv.Filter = o =>
            {
                Recurso p = o as Recurso;

                if (chkExoticos.IsChecked.Value)
                    return p.tipo == Recurso.Tipo.Exotico;                //Si esta chequeado y es comun se muestra.
                if (p.tipo == Recurso.Tipo.Exotico)
                    return true;
                if (p.rareza == Rareza.Comun)
                    return chkComunes.IsChecked.Value;
                if (p.rareza == Rareza.PocoComun)
                    return chkPocoComunes.IsChecked.Value;
                if (p.rareza == Rareza.Raro)
                    return chkRaros.IsChecked.Value;

                if (p.rareza == Rareza.Epico)
                    return chkEpicos.IsChecked.Value;
              

                return false;

            };
        }

      
    }
}
