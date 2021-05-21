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
    /// Логика взаимодействия для Sphere1.xaml
    /// </summary>
    public partial class Sphere1 : Page
    {
        double Radius = 0;
        string RadiusStr = "";
        public Sphere1()
        {
            InitializeComponent();
        }
        public bool IsNumber(string gg)
        {
            bool is_num = true;
            if (gg.Length == 0)
            {
                is_num = false;
                return is_num;
            }
            for (int i = 0; i < gg.Length; i++)
            {
                if (gg[i] < '0' || gg[i] > '9')
                {
                    is_num = false;
                    break;
                }
            }
            return is_num;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainStart());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RadiusStr = R.Text;
            if (IsNumber(RadiusStr))
            {
                 Radius = Convert.ToDouble(R.Text);
                 V.Text = Convert.ToString(4*Math.PI*Math.Pow(Radius,2));
                 S.Text = Convert.ToString((4*Math.PI*Math.Pow(Radius,3))/3);
            }
            else
            {
                V.Text = "Error R не число!";
                S.Text = "Error R не число!";
            }
        }
    }
}
