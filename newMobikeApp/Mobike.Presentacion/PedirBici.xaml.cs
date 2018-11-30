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
using Mobike.Presentacion;

namespace Mobike.Presentación
{
    /// <summary>
    /// Lógica de interacción para PedirBici.xaml
    /// </summary>
    public partial class PedirBici : Window
    {
        DateTime inicio = DateTime.Now;
        Manejadora mane = new Manejadora();
        Bicicleta b = new Bicicleta();
        Usuario usu = new Usuario();
        string usuarioEmail;
        string usuarioPass;

        public PedirBici(string umail, string upass)
        {
            InitializeComponent();
            ListadoEstacionamientos();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            usuarioEmail = umail;
            usuarioPass = upass;
        }
        
        private void ListadoEstacionamientos()
        {
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
                    cmbEst2.Items.Add(nombreEst);
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
                //Hace visibles los label y el textbox relacionados con el recorrido.
                lblValor.Visibility = Visibility.Visible;
                lblKm.Visibility = Visibility.Visible;
                txtKm.Visibility = Visibility.Visible;
                cmbEst.Visibility = Visibility.Hidden;
                cmbEst2.Visibility = Visibility.Visible;

                if (b.GetEstado(cmbPatente.Text) == "Disponible")
                {
                    b.CambiarEstado(cmbPatente.Text);
                    string est = b.GetEstado(cmbPatente.Text);
                    inicio = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Verifique que la bicicleta esté disponible");
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione en qué estacionamiento está y qué bicicleta eligió", "Error");
                cmbEst.Focus();
            }
        }

        private void btnFin_Click(object sender, RoutedEventArgs e)
        {
            int km = Convert.ToInt32(txtKm.Text);
            string patente = cmbPatente.Text;
            int idestacionamiento = cmbEst2.SelectedIndex + 1;
            double valor = ((km * 150) + 30 * 30);
            lblValor.Content = "Valor del Recorrido: $ " + valor;
            
            if (cmbEst2.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, indique en qué estacionamiento dejó la bicicleta.", "Mobike");
                return;
            }

            DateTime fin = DateTime.Now;
            double minutos = fin.Subtract(inicio).TotalMinutes;
            try
            {
                if (usu.Login(usuarioEmail, usuarioPass) == true)
                {
                    if (mane.AddRecorrido(km, inicio.ToString("yyyy-MM-dd HH:mm:ss"), fin.ToString("yyyy-MM-dd HH:mm:ss"),
                                          Math.Round(minutos), Math.Round(valor), usu.IdPersona, usuarioEmail, patente) == true)
                    {
                        b.CambiarEstado(patente);
                        b.CambiarEstacionamiento(patente, idestacionamiento);
                        MessageBox.Show("Recorrido registrado con éxito.", "Mobike");
                    }
                    else
                    {
                        MessageBox.Show("\r" + km +
                                        "\r" + inicio.ToString("yyyy-MM-dd HH:mm:ss") +
                                        "\r" + fin.ToString("yyyy-MM-dd HH:mm:ss") +
                                        "\r" + Math.Round(minutos) +
                                        "\r" + Math.Round(valor) +
                                        "\r" + usu.IdPersona +
                                        "\r" + usuarioEmail +
                                        "\r" + cmbPatente.Text, "Error qlo");
                    }
                }
            }
            catch (Exception zz)
            {
                throw zz;
            }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(usuarioEmail, usuarioPass);
            mainWindow.Show();
            this.Close();
        }

        private void TxtKm_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
