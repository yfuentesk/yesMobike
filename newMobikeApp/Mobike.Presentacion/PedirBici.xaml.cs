using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Mobike.Negocios;

namespace Mobike.Presentación
{
    /// <summary>
    /// Lógica de interacción para PedirBici.xaml
    /// </summary>
    public partial class PedirBici : Window
    {

        DateTime inicio = DateTime.MinValue;
        public PedirBici()
        {
            InitializeComponent();
            ListadoEstacionamientos();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        
        private void ListadoEstacionamientos()
        {
            Manejadora mane = new Manejadora();
            SqlConnection conn = mane.ConexionDBQuery();

            try
            {
                conn.Open();

                string query = "SELECT * FROM estacionamiento;";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlCommand comando = conn.CreateCommand();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string nombreEst = dr.GetString(1);
                    cmbEst.Items.Add(nombreEst);
                }
            }
            catch (Exception zz)
            {
                throw zz;
            }
            finally
            {
                conn.Close();
            }
        }

        private void cmbEst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Manejadora mane = new Manejadora();
            SqlConnection conn = mane.ConexionDBQuery();

            cmbPatente.Items.Clear();
            try
            {
                conn.Open();

                int index = cmbEst.SelectedIndex + 1;
                string query = "SELECT * FROM bicicleta WHERE id_estF = '" + index + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlCommand comando = conn.CreateCommand();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string patente = dr.GetString(0);
                    cmbPatente.Items.Add(patente);
                }
            }
            catch (Exception ee)
            {
                throw ee;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnComienzo_Click(object sender, RoutedEventArgs e)
        {
            if (cmbEst.SelectedIndex != -1 && cmbPatente.SelectedIndex != -1)
            {
                Bicicleta b = new Bicicleta();
                //Hace visibles los label y el textbox relacionados con el recorrido.
                lblValor.Visibility = Visibility.Visible;
                lblKm.Visibility = Visibility.Visible;
                txtKm.Visibility = Visibility.Visible;

                if (b.GetEstado(cmbPatente.Text) == "Disponible")
                {
                    b.CambiarEstado(cmbPatente.Text);
                    //Aquí debe ir el cálculo del valor
                    string est = b.GetEstado(cmbPatente.Text);
                    inicio = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Verifique que la bicicleta esté disponible");
                }


                //Aquí debe ir el cálculo del valor

                //El cual se debe añadir al label de Valor.
                lblValor.Content = "Valor del Recorrido: $ XXX";
            }
            else
            {
                MessageBox.Show("Por favor seleccione en qué estacionamiento está y qué bicicleta eligió", "Error");
                cmbEst.Focus();
            }
        }

        private void btnFin_Click(object sender, RoutedEventArgs e)
        {
            Bicicleta b = new Bicicleta();
            int km = Convert.ToInt32(txtKm.Text);
            int valor = ((km * 150) + 30 * 30);
            lblValor.Content = "Valor del Recorrido: $ " + valor;
            b.CambiarEstado(cmbPatente.Text);
            string est = b.GetEstado(cmbPatente.Text);
            DateTime fin = DateTime.Now;
            Recorrido r = new Recorrido(km, inicio, fin, 30, valor, "123", "123", cmbPatente.Text);
            if (r.Create())
            {
                MessageBox.Show("DALEEE");
            }
            else
            {
                MessageBox.Show("\r" + km +
                                "\r" + inicio +
                                "\r" + fin +
                                "\r" + 30 +
                                "\r" + valor +
                                "\r123" +
                                "\r123" +
                                "\r" + cmbPatente.Text);

                Clipboard.SetText("\r" + km +
                                "\r" + inicio +
                                "\r" + fin +
                                "\r" + 30 +
                                "\r" + valor +
                                "\r191919" +
                                "\raeaeae" +
                                "\r" + cmbPatente.Text);

            }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void TxtKm_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
