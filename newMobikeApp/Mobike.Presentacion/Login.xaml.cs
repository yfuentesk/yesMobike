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

namespace Mobike.Presentacion
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        string usuarioEmail = "correo";
        string usuarioPass = "pass";
        public Login()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp regi = new SignUp();
            regi.Show();
            this.Close();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            usuarioEmail = txtEmail.Text;
            usuarioPass = txtPass.Password;
            Usuario usu = new Usuario();
            try
            {
                if (usu.Login(usuarioEmail, usuarioPass) == true)
                {
                    MessageBox.Show("Sesión iniciada correctamente", "Mobike");
                    MainWindow main = new MainWindow(usuarioEmail, usuarioPass);
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesión" +
                        "\rIntente de nuevo o registrese.", "Mobike");
                }
            }
            catch (Exception zz)
            {
                throw new Exception(zz.Message);
            }           
        }
    }
}
