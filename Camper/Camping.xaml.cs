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

namespace Camper
{
    /// <summary>
    /// Interaction logic for Camping.xaml
    /// </summary>
    public partial class Camping : Window
    {
        public Camping()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Hello World! Basic Inventory");
        }
    }
}
