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
using Mobike.Negocios;

namespace Mobike.Presentación
{
    /// <summary>
    /// Lógica de interacción para SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        Manejadora man = new Manejadora();
        public SignUp()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btnRegistro_Click(object sender, RoutedEventArgs e)
        {
            Usuario us = new Usuario(txtRut.Text,
                                    txtPass.Password,
                                    txtNombre.Text,
                                    txtDireccion.Text,
                                    Convert.ToInt64(txtTarjeta.Text),
                                    0,
                                    txtCorreo.Text);
            if (us.Create())
            {

                MessageBox.Show("Usuario Creado con exito");

            }
            else
            {
                MessageBox.Show("rut: " + txtRut.Text +
                                "\rPass: " + txtPass.Password +
                                "\rNombre: " + txtNombre.Text +
                                "\rTarjeta: " + Convert.ToInt64(txtTarjeta.Text) +
                                "\r: 0" +
                                "\rDireccion: " + txtDireccion.Text+
                                "\r"+txtCorreo.Text);
            }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
