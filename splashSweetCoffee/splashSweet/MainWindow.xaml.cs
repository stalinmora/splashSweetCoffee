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
            DataContext = new List<Person>
            {
                new Person {Name="Stalin" },
                new Person {Name="Carlos" },
                new Person {Name="Jhonny" },
                new Person {Name="Gabriela" }

            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person persona = ((Button)sender).Tag as Person;
            MessageBox.Show(persona.Name);
        }
    }

    public class Person
    {
        public string Name { set; get; }
    }
}
