using WpfMenu.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfMenu.Views
{
    /// <summary>
    /// Lógica de interacción para Textos.xaml
    /// </summary>
    public partial class Textos : Window
    {
        TextoController tc;
        public Textos()
        {
            InitializeComponent();
            setUpController();
        }
        public void setUpController()
        {
            tc = new TextoController(this);
            RoutedEventHandler routed = new RoutedEventHandler(tc.MainWindowEvent);

            this.file1.Click += routed; // Hace que el boton sea funcional
            this.file2.Click += routed;
            this.btnGuardar.Click += routed;
        }


    }
}
