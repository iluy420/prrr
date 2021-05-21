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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainStart.xaml
    /// </summary>
    public partial class MainStart : Page
    {
        public MainStart()
        {
            InitializeComponent();
        }

        private void Sphere_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Sphere1());
        }

        private void Cone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cone1());
        }

        private void Cylinder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cylinder1());
        }

        private void TruncatedCone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TruncatedCone1());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
