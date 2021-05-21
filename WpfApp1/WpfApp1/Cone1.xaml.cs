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
    /// Логика взаимодействия для Cone1.xaml
    /// </summary>
    public partial class Cone1 : Page
    {
        double Radius = 0;
        string RadiusStr = "";
        double Hig = 0;
        string HigStr = "";
        double Vcon = 0;
        double Sosncon = 0;
        double sbokcon = 0;
        double sobshcon = 0;
        double Lcon = 0;
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
        public Cone1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainStart());
        }

        private void rezcon_Click(object sender, RoutedEventArgs e)
        {
            RadiusStr = R1.Text;
            if (IsNumber(RadiusStr))
            {
                Radius = Convert.ToDouble(R1.Text);
                HigStr = H1.Text;
                if (IsNumber(HigStr))
                {
                    Hig = Convert.ToDouble(H1.Text);
                    Lcon = Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Hig, 2));
                    V1.Text = Convert.ToString((Math.PI * Math.Pow(Radius, 2)*Hig)/3);
                    Sbok1.Text = Convert.ToString(Math.PI * Radius * Lcon);
                    Sosn1.Text = Convert.ToString(Math.PI*Math.Pow(Radius,2));
                    Sobsh1.Text = Convert.ToString(Math.PI*Radius*(Radius+Lcon));
                }
                else
                {
                    V1.Text = "Error H не число!";
                    Sbok1.Text = "Error H не число!";
                    Sosn1.Text = "Error H не число!";
                    Sobsh1.Text  = "Error H не число!";
                }
                
            }
            else
            {
                V1.Text = "Error R не число!";
                Sbok1.Text = "Error R не число!";
                Sosn1.Text = "Error R не число!";
                Sobsh1.Text = "Error R не число!";
            }
        }
    }
}
