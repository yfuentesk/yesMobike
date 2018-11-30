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
using Mobike.Presentacion;

namespace Mobike.Presentación
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string usuarioEmail;
        string usuarioPass;

        public MainWindow(string umail, string upass)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            usuarioEmail = umail;
            usuarioPass = upass;
        }
       
        private void btnReco_Click(object sender, RoutedEventArgs e)
        {
            MisRecorridos reco = new MisRecorridos(usuarioEmail, usuarioPass);
            reco.Show();
            this.Hide();
        }

        private void btnBici_Click(object sender, RoutedEventArgs e)
        {
            PedirBici bici = new PedirBici(usuarioEmail, usuarioPass);
            bici.Show();
            this.Hide();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
