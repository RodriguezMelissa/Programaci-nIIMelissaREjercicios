using WpfMenu.Models;
using WpfMenu.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Ejercicios1_2_3.Controllers
{
    internal class ConvertidorController
    {
        ConvertidorDeMonedas cm;

        public ConvertidorController(ConvertidorDeMonedas cm)
        {
            this.cm = cm;
        }

        public void MainWindowEvent(object sender, RoutedEventArgs e)
        {
            // Cambiamos MenuItem por Button porque ahora vamos a trabajar con botones no con un menu
            Button botones = (Button)sender;
            switch (botones.Name)
            {
                // Cada caso es el nombre de cada boton, adentro agregas la funcionalidad que quieras
                case "btnConvertir":
                    mostrarMonto();
                    break;
            }

        }

        private void mostrarMonto()
        {
            WindowModel wm = new WindowModel();
            cm.fecha.Content = DateTime.Now.Date.ToString("dd-MM-yyyy");
            float respuesta = wm.ConvertidorMonedas(cm.InputMoneda.SelectedIndex, cm.OutputMoneda.SelectedIndex, float.Parse(cm.InputMonto.Text));
            cm.OutputMonto.Text = respuesta.ToString();
        }
    }
}