﻿using System;
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

namespace Mobike.Presentación
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
       
        private void btnReco_Click(object sender, RoutedEventArgs e)
        {
            Recorridos reco = new Recorridos();
            reco.Show();
            this.Close();
        }

        private void btnBici_Click(object sender, RoutedEventArgs e)
        {
            PedirBici bici = new PedirBici();
            bici.Show();
            this.Close();
        }
        
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }
        
        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
            this.Close();
        }
    }
}
