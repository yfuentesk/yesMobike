using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
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
            try
            {
                us.Create();
                MessageBox.Show("Usuario Creado con exito");
            }
            catch (ArgumentException zz)
            {
                //Clipboard.SetText("rut: " + txtRut.Text +
                //                "\rPass: " + txtPass.Password +
                //                "\rNombre: " + txtNombre.Text +
                //                "\rTarjeta: " + Convert.ToInt64(txtTarjeta.Text) +
                //                "\r: 0" +
                //                "\rDireccion: " + txtDireccion.Text+
                //                "\r"+txtCorreo.Text);

                throw new Exception(zz.Message);
            }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void TxtTarjeta_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
