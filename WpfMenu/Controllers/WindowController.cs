using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfMenu.Models;
using WpfMenu.Views;
namespace WpfMenu.Controllers
{
    internal class WindowController
    {
        WindowMenu menu;
        public WindowController(WindowMenu menu)
        {
            this.menu = menu;
        }
        public void MainWindowEvent(object sender, RoutedEventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            WindowModel wm = new WindowModel();
            switch (mi.Name)
            {
                case "btnConfigurar":
                    wm.Prueba();
                    break;

                case "btnTextos":
                    break;

                case "btnConvertidordemonedas":
                    break;

                case  "btnSalir":
                    break;
                   
                    
            }

        }
    }
    
}
