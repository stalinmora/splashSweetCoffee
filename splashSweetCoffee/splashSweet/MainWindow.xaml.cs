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

namespace splashSweet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new List<Menssage>
            {
                new Menssage {mensaje="Prueba de Mensaje 1" ,persona="Carlos Fabre" },
                new Menssage {mensaje="Prueba de Mensaje 2" ,persona="Stalin Mora"},
                new Menssage {mensaje="Prueba de Mensaje 3" ,persona="Gabriela Fuentes"},
                new Menssage {mensaje="Prueba de Mensaje 4" ,persona="Jhonny Idrovo"}

            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menssage mensaje = ((Button)sender).Tag as Menssage;
            MessageBox.Show(mensaje.mensaje);
        }
    }

    public class Menssage
    {
        public string mensaje { set; get; }
        public string persona { set; get; }
    }
}
