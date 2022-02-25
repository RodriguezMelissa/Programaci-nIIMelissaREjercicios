using WpfMenu.Models;
using WpfMenu.Views;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfMenu.Controllers
{
    internal class TextoController
    {
        Textos txt;

        public TextoController(Textos txt)
        {
            this.txt = txt;
        }


        public void MainWindowEvent(object sender, RoutedEventArgs e)
        {
            // Cambiamos MenuItem por Button porque ahora vamos a trabajar con botones no con un menu
            Button botones = (Button)sender;
            WindowModel wm = new WindowModel();
            string ruta1 = "";
            string ruta2 = "";
            string message = "";
            WindowModel wmodel = new WindowModel();
            switch (botones.Name)
            {
                
                case "file1":
                    Archivo1();
                   
                    break;

                case "file2":
                   Archivo2();

                   break;
                case "btnGuardar":
                    Guardar();
                    break;
                    
            }


        }
        public void  Archivo1 ()

        {
            string ruta1 = "";
            string message = "";
            OpenFileDialog file_1 = new OpenFileDialog();
            if(txt.rute2.Text == "")
            {
                file_1.ShowDialog();
                ruta1 = file_1.FileName;
                txt.rute1.Text = ruta1;
                message = leer_fichero(ruta1);
                txt.Block.Text = message;
                MessageBox.Show(message);

            }    
            else
            {
                file_1.ShowDialog();
                ruta1 = file_1.FileName;
                txt.rute1.Text = ruta1;
                message = leer_fichero(ruta1);
                txt.Block.Text = txt.Block.Text += message;
                MessageBox.Show(message);

            }
        }

        public void Archivo2()
        {
            string ruta2 = "";
            string message = "";
            
            OpenFileDialog file_1 = new OpenFileDialog();
           if (txt.rute1.Text == "")
            {
                file_1.ShowDialog();
                ruta2 = file_1.FileName;
                txt.rute1.Text = ruta2;
                message = leer_fichero(ruta2);
                txt.Block.Text = message;
                MessageBox.Show(message);

           }
           else
           {
                file_1.ShowDialog();
                ruta2 = file_1.FileName;
                txt.rute1.Text = ruta2;
                message = leer_fichero(ruta2);
                txt.Block.Text = txt.Block.Text += message;
                MessageBox.Show(message);

            }
        }
        public String leer_fichero(string ruta)
        {
            string text = System.IO.File.ReadAllText(@ruta);
            return text;
        }
        public void Guardar ()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
            System.IO.File.WriteAllText(save.FileName,txt.Block.Text);


        }

    }
}


       


