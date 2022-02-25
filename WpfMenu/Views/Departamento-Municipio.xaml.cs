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

namespace WpfMenu.Views
{
    /// <summary>
    /// Lógica de interacción para Departamento_Municipio.xaml
    /// </summary>
    public partial class Departamento_Municipio : Window
    {
        public Departamento_Municipio()
        {
            InitializeComponent();
           
            List<string> Boaco = new List<string>()
            {"Boaco", "Camoapa", "Santa Lucía", "San José De los Remate", "San Lorenzo", "Teustepe"
            };
            List<string> Carazo = new List<string>()
            {
             "Jinotepe", "Diriamba", "San Marcos", "Santa Teresa", "Dolores", "La Paz Carazo", "El Rosario", "La Conquista"
            };
            List<string> Chinandega = new List<string>()
            {
            "Chinandega", "Corinto", "El Realejo", "Chichigalpa", "Posoltega", "El Viejo", "Puerto Morazán", "Somotillo", "Villa Nueva", "Santo Tomás del Norte", "Cinco Pinos", "San Francisco Del Norte", "San Pedro Del Norte"
            };
            List<string> Chontales = new List<string>()
            {
                "Juigalpa", "Acoyapa", "Santo Tomás", "Villa Sandino", "San Pedro de Lóvago", "La Libertad", "Santo Domingo", "San Francisco Cuapa", "El Coral"
            };
            List<string> Estelí = new List<string>()
            {
            "Estelí", "Pueblo Nuevo", "Condega", "San Juan Limay", "La Trinidad", "San Nicolás"
            };
            List<string> Granada = new List<string>()
            {
            "Granada", "Nandaime", "Diriomo", "Diriá"
            };
            List<string> Jinotega = new List<string>()
            {

            "Jinotega", "San Rafael Del Norte", "San Sebastián Yalí", "La Concordia", "San José De Bocay", "El Cuá Bocay", "Santa María Pantasma"

            };
            List<string> León = new List<string>()
            {
            "León", "El Jicaral", "La Paz Centro", "Santa Rosa Del Peñón", "Quetzalguaque", "Nagarote", "El Sauce", "Achuapa", "Telica", "Larreynaga Malpaisillo"
            };
            List<string> Matagalpa = new List<string>
            {
            "Matagalpa", "San Ramón", "Matiguás", "Muy Muy", "Esquipulas", "San Dionisio", "San Isidro", "Sébaco", "Ciudad Darío", "Terrabona", "Rio Blanco", "Tuma La Dalia", "Rancho Grande"
            };
            List<string> Masaya = new List<string>()
            {
            "Masaya", "Nindirí", "Tisma", "Catarina", "San Juan Oriente", "Niquinohomo", "Nandasmo", "Masatepe", "La Concepción"
            };
            List<string> Madriz = new List<string>()
            {
            "Somoto", "Telpaneca", "Sn Juan Rio Coco", "Palacagüina", "Yalagüina", "Totogalpa", "San Lucas", "La Sabanas", "San José De Cusmapa"
            };
            List<string> Managua = new List<string>()
            {
            "Managua", "San Rafael Del Sur", "Tipitapa", "Villa Carlos Fonseca", "San Francisco Libre", "Mateare", "Ticuantepe", "Ciudad Sandino", "El Crucero"
            };
            List<string> NuevaSegovia = new List<string>()
            {
            "Ocotal", "Santa María", "Macuelizo", "Dipilto", "Ciudad Antigua", "Mozonte", "San Fernando", "El Jícaro", "Jalapa", "Murra", "Quilalí", "Wiwilí", "Wiwilí Nueva Segovia"
            };
            List<string> RioSanJuan = new  List<string> ()
            {
            "San Carlos", "El Castillo", "San Miguelito", "Morrito", "San Juan del Norte", "El Almendro"
            };
            List<string> Rivas = new List<string>()
            {
            "Rivas", "San Jorge", "Buenos Aires", "Potosí", "Belén", "Tola", "San Juan Sur", "Cárdenas", "Moyogalpa", "Altagracia"
            };
            List<string>CostaCaribeNorte = new List<string>()
            {
             "Puerto Cabezas", "Waspán", "Siuna", "Bonanza", "Rosita", "Bocana Paiwás", "Waslala", "Corn Island"
            };
            List<string> CostaCaribeSur = new List<string>()
            {
            "Bluefields", "El Rama", "Muelle De Los Buelles", "La Cruz De Rio Grande", "Prinzapolka", "Nueva Guinea", "Tortuguero", "Kukra Hill", "Laguna De Perlas", "Desembocadura Rio Grande", "El Ayote"
            };
            

        }

        private void btndepart_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem lbi = ((sender as ComboBox).SelectedItem as ComboBoxItem);
            MessageBox.Show(lbi.Content.ToString());  
                }

        private void btnmunicipio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
            
        }
    }
    
       
    }

