using System;
using System.Collections.Generic;
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

namespace WpfCalculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ClaseCalculadora> Listacalculo = new List<ClaseCalculadora>(); //creo una lista vacia para guardarme los calculos

        //variables :
        decimal val1 = 0;
        decimal val2 = 0;
        string ope = "";

        public MainWindow()
        {
            InitializeComponent();
        }


        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                val2 = Convert.ToDecimal(txtres.Text);

                ClaseCalculadora micalculadora = new ClaseCalculadora(); //creo una instacia de la clase  
                micalculadora.valor1 = val1;
                micalculadora.valor2 = val2;
                micalculadora.operacion = ope;
                micalculadora.mioperacion(); //llamo a la funcion que hace los calculos 
                txtres.Text = Convert.ToString( micalculadora.resultado);

                Listacalculo.Add(micalculadora); //agrego las operaciones a la lista que inicilamente esta vacia 
                dgcalculos.ItemsSource = Listacalculo; //agrego la lista a la grilla
                dgcalculos.Items.Refresh();

            }
            catch

            {
                MessageBox.Show("Verifique los datos ingresados", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        //metodo para agregar el numero seleccionado al texbox de la "pantalla"
        private void Mimetodo(string numero)
        {
            txtres.Text = txtres.Text + numero;
            txtres.Focus();
        }
        private void _9_Click(object sender, RoutedEventArgs e)
        {
            Mimetodo("9");
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            Mimetodo("8");
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            Mimetodo("7");
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            Mimetodo("6");
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            Mimetodo("5");
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            Mimetodo("4");
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            Mimetodo("3");
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            Mimetodo("2");
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            Mimetodo("1");
        }

        private void _0_Click(object sender, RoutedEventArgs e)
        {
            Mimetodo("0");
        }

         //botones operaciones
        private void btnsuma_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                val1 = Convert.ToDecimal(txtres.Text);
                ope = "Suma";
                txtres.Text = "";

            }
            catch
            {
                MessageBox.Show("Verifique los datos ingresados", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnresta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                val1 = Convert.ToDecimal(txtres.Text);
                ope = "Resta";
                txtres.Text = "";


            }
            catch
            {
                MessageBox.Show("Verifique los datos ingresados", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnmult_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                val1 = Convert.ToDecimal(txtres.Text);
                ope = "Multiplicacion";
                txtres.Text = "";
            }
            catch
            {
                MessageBox.Show("Verifique los datos ingresados", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btndividir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                val1 = Convert.ToDecimal(txtres.Text);
                ope = "Division";
                txtres.Text = "";
            }
            catch
            {
                MessageBox.Show("Verifique los datos ingresados", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnlimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtres.Text = "";
        }

        private void btnlimpiar1_Click(object sender, RoutedEventArgs e)
        {
            dgcalculos.ItemsSource = null;

            Listacalculo.Clear();
        }
    }
}
