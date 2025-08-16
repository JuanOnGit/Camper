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
    /// Interaction logic for AddViewCamper.xaml
    /// </summary>
    public partial class AddViewCamper : Page
    {
        public AddViewCamper()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SaveCamper(camperNametextBox.Text);
        }

        private void SaveCamper(string camperName)
        {
            // Code to save camper details goes here
            MessageBox.Show("Camper" + camperName + " saved successfully!");
        }
    }
}
