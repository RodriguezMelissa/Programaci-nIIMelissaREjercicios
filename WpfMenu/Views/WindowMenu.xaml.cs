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
using WpfMenu.Controllers;

namespace WpfMenu.Views
{
    /// <summary>
    /// Lógica de interacción para WindowMenu.xaml
    /// </summary>
    public partial class WindowMenu : Window
    {
        WindowController menucont;
        public WindowMenu()
        {
            InitializeComponent();
            setUpController();
        }
        private void setUpController()
        {
            menucont = new WindowController(this);
            RoutedEventHandler routed = new RoutedEventHandler(menucont.MainWindowEvent);
            this.btnSalir.Click += routed;
            this.btnConfigurar.Click += routed;
            this.btnConvertidordemonedas.Click += routed;
            this.btnTextos.Click += routed;
        }

        private void btnConvertidordemonedas_Click(object sender, RoutedEventArgs e)
        {
            ConvertidorDeMonedas monedas = new ConvertidorDeMonedas();
            monedas.ShowDialog();
        }

        private void btnTextos_Click(object sender, RoutedEventArgs e)
        {
            Textos textos = new Textos();
            textos.ShowDialog();
        }

        private void btnConfigurar_Click(object sender, RoutedEventArgs e)
        {
            Configurar conf = new Configurar();
            conf.ShowDialog();
        }

        private void btnnicaragua_Click(object sender, RoutedEventArgs e)
        {
            Departamento_Municipio dp = new Departamento_Municipio();
            dp.ShowDialog();
        }
    }
}
