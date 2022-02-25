using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfMenu.Models
{
    internal class WindowModel
    {
        private string mensaje;

        public void setMensaje(string mensaje)
        {
            this.mensaje = mensaje;
        }

        public string getMensaje()
        {
            return mensaje;
        }

        public float ConvertidorMonedas(int InputMoneda, int OutputMoneda, float InputMonto)
        {
            //Arreglo de 10 espacios
            //float[] dolares = new float[10]; 
            /*
              Input Output Moneda 
                0 = Cordobas
                1 = Dolares
                2 = Euros
             */
            float cambio = (float)0.0;

            if (InputMoneda == OutputMoneda)
                return InputMonto;
            else if (InputMoneda == 0)
            {
                // de Cordobas a Dolar
                if (OutputMoneda == 1)
                    cambio = InputMonto / (float)(35.4075);
                else if (OutputMoneda == 2)
                    cambio = InputMonto / (float)(40.0195); // de Cordobas a Euros
            }
            else if (InputMoneda == 1) // Dolares
            {
                // de Dolares a Cordobas
                if (OutputMoneda == 0)
                    cambio = InputMonto * (float)(35.4075);
                else if (OutputMoneda == 2)
                    cambio = InputMonto * (float)(0.884606); // de Dolares a Euros
            }
            else if (InputMoneda == 2)
            {
                // de Euros a Cordobas
                if (OutputMoneda == 0)
                    cambio = InputMonto * (float)(40.0195);
                else if (OutputMoneda == 1)
                    cambio = InputMonto * (float)(1.13041); // de Euros a Dolares
            }

            return cambio;
        }

        internal void Prueba()
        {
            throw new NotImplementedException();
        }

        public void guardarFichero(string nombre)
        {
            string contenido = getMensaje();
            string path = @"c:\Textos\" + nombre + ".txt";
            MessageBox.Show(contenido);
            try
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(contenido);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
            }
        }
    }
}
