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
    /// Логика взаимодействия для Cylinder1.xaml
    /// </summary>
    public partial class Cylinder1 : Page
    {
        double Radius = 0;
        string RadiusStr = "";
        double Hig = 0;
        string HigStr = "";
        public bool IsNumber(string gg)
        {
            bool is_num = true;
            if(gg.Length == 0)
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
        public Cylinder1()
        {
            InitializeComponent();
        }

        private void exitcyl_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainStart());
        }

        private void rezcyl_Click(object sender, RoutedEventArgs e)
        {
            RadiusStr = R2.Text;
            if (IsNumber(RadiusStr))
            {
                Radius = Convert.ToDouble(R2.Text);
                HigStr = H2.Text;
                if (IsNumber(HigStr))
                {
                    Hig = Convert.ToDouble(H2.Text);
                    V2.Text = Convert.ToString(Math.PI * Math.Pow(Radius, 2) * Hig);
                    Sbok2.Text = Convert.ToString(2*Math.PI * Radius * Hig);
                    Sosn2.Text = Convert.ToString(Math.PI * Math.Pow(Radius, 2));
                    Sobsh2.Text = Convert.ToString(2* Math.PI * Radius*( Radius + Hig));
                }
                else
                {
                    V2.Text = "Error H не число!";
                    Sbok2.Text = "Error H не число!";
                    Sosn2.Text = "Error H не число!";
                    Sobsh2.Text = "Error H не число!";
                }

            }
            else
            {
                V2.Text = "Error R не число!";
                Sbok2.Text = "Error R не число!";
                Sosn2.Text = "Error R не число!";
                Sobsh2.Text = "Error R не число!";
            }
        }
    }
}
