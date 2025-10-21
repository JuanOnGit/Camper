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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();

        }

        private void ViewAddCamper_Click(object sender, RoutedEventArgs e)
        {
                NavigationWindow navigation = new NavigationWindow();
                navigation.Source = new Uri("ViewAddCamper.xaml", UriKind.Relative);
                navigation.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow navigationWindow = new NavigationWindow();
            navigationWindow.Source = new Uri("Equipment.xaml", UriKind.Relative);
            navigationWindow.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationWindow navigationWindow = new NavigationWindow();
            navigationWindow.Source = new Uri("Camper Log.xaml", UriKind.Relative);
            navigationWindow.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationWindow navigationWindow = new NavigationWindow();
            navigationWindow.Source = new Uri("Campsites.xaml", UriKind.Relative);
            navigationWindow.Show();
        }
    }
}
