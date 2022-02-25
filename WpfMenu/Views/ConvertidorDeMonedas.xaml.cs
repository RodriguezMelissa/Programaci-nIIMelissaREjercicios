using WpfMenu.Controllers;
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
using Ejercicios1_2_3.Controllers;

namespace WpfMenu.Views
{
    /// <summary>
    /// Lógica de interacción para ConvertidorDeMonedas.xaml
    /// </summary>
    public partial class ConvertidorDeMonedas : Window
    {
        ConvertidorController cc;
        public ConvertidorDeMonedas()
        {
            InitializeComponent();
                setUpController();
            }
            public void setUpController()
            {
                cc = new ConvertidorController(this);
                RoutedEventHandler routed = new RoutedEventHandler(cc.MainWindowEvent);

                this.btnConvertir.Click += routed; // Hace que el boton sea funcional
            }
        }
    }
    

