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

namespace Camper
{
    /// <summary>
    /// Interaction logic for Camper_Log.xaml
    /// </summary>
    public partial class Camper_Log : Page
    {
        public Camper_Log()
        {
            InitializeComponent();
        }

        public void SaveLogs_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Hello World! Camper Log");
        }
    }
}
