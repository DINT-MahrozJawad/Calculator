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

namespace Calculator
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Name == "uno")
                Texto.Text = Texto.Text + "1";
            if (((Button)sender).Name == "dos")
                Texto.Text = Texto.Text + "2";
            if (((Button)sender).Name == "tres")
                Texto.Text = Texto.Text + "3";
            if (((Button)sender).Name == "cuatro")
                Texto.Text = Texto.Text + "4";
            if (((Button)sender).Name == "cinco")
                Texto.Text = Texto.Text + "5";
            if (((Button)sender).Name == "seis")
                Texto.Text = Texto.Text + "6";
            if (((Button)sender).Name == "siete")
                Texto.Text = Texto.Text + "7";
            if (((Button)sender).Name == "ocho")
                Texto.Text = Texto.Text + "8";
            if (((Button)sender).Name == "nueve")
                Texto.Text = Texto.Text + "9";
            if (((Button)sender).Name == "cero")
                Texto.Text = Texto.Text + "0";
        }
    }
}
