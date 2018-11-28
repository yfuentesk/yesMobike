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

        }

        private void btnFin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
