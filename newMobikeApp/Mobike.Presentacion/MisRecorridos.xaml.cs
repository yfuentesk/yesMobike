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
using System.Windows.Shapes;
using Mobike.Presentación;
using Mobike.Negocios;
using System.Data;

namespace Mobike.Presentacion
{
    /// <summary>
    /// Lógica de interacción para MisRecorridos.xaml
    /// </summary>
    public partial class MisRecorridos : Window
    {
        Manejadora mane = new Manejadora();
        Usuario usu = new Usuario();
        string usuarioEmail;
        string usuarioPass;

        public MisRecorridos(string umail, string upass)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            usuarioEmail = umail;
            usuarioPass = upass;
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(usuarioEmail, usuarioPass);
            mainWindow.Show();
            this.Close();
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (usu.Login(usuarioEmail, usuarioPass) == true)
                {
                    DataTable dt = mane.Tablita(usuarioEmail);
                    dtgRecorrido.ItemsSource = dt.DefaultView;
                }
                else
                {
                    MessageBox.Show("Login Incorrecto", "Error", MessageBoxButton.OK);
                }
            }
            catch (Exception zz)
            {
                throw zz;
            }
        }
    }
}
