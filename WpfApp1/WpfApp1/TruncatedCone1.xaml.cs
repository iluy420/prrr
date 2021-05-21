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
    /// Логика взаимодействия для TruncatedCone1.xaml
    /// </summary>
    public partial class TruncatedCone1 : Page
    {
        double Radius = 0;
        string RadiusStr = "";
        double Radius1 = 0;
        string RadiusStr1 = "";
        double Hig = 0;
        string HigStr = "";
        double Ltr = 0;
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
        public TruncatedCone1()
        {
            InitializeComponent();
        }

        private void exitcyl_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainStart());
        }

        private void rezctr_Click(object sender, RoutedEventArgs e)
        {
            RadiusStr = R3.Text;
            if (IsNumber(RadiusStr))
            {
                Radius = Convert.ToDouble(R3.Text);
                RadiusStr1 = R13.Text;
                if (IsNumber(RadiusStr1))
                {
                    Radius1 = Convert.ToDouble(R13.Text);
                    HigStr = H3.Text;
                    if (IsNumber(HigStr))
                    {
                        Hig = Convert.ToDouble(H3.Text);
                        if (Radius1 > Radius)
                        {
                            Ltr = Math.Sqrt(Math.Pow(Radius1 - Radius, 2) + Math.Pow(Hig, 2));
                            Sbok3.Text = Convert.ToString(Math.PI * Ltr * (Radius + Radius1));
                            Sosn3.Text = Convert.ToString(Math.PI * Math.Pow(Radius, 2));
                            Sosn13.Text = Convert.ToString(Math.PI * Math.Pow(Radius1, 2));
                            Sobsh3.Text = Convert.ToString(Math.PI *(Math.Pow(Radius1,2) + Math.Pow(Radius, 2)+Ltr*(Radius+Radius1)));
                            V3.Text = Convert.ToString(((Math.PI)/3) *Hig* (Math.Pow(Radius1, 2)+ Radius*Radius1+Math.Pow(Radius, 2)));
                        }
                        else
                        {
                            V3.Text = "Error R1 >= R2!";
                            Sbok3.Text = "Error R1 >= R2!";
                            Sosn3.Text = "Error R1 >= R2!";
                            Sosn13.Text = "Error R1 >= R2!";
                            Sobsh3.Text = "Error R1 >= R2!";
                        }
                    }
                    else
                    {
                        V3.Text = "Error H не число!";
                        Sbok3.Text = "Error H не число!";
                        Sosn3.Text = "Error H не число!";
                        Sosn13.Text = "Error H не число!";
                        Sobsh3.Text = "Error H не число!";
                    }
                }
                else
                {
                    V3.Text = "Error R2 не число!";
                    Sbok3.Text = "Error R2 не число!";
                    Sosn3.Text = "Error R2 не число!";
                    Sosn13.Text = "Error R2 не число!";
                    Sobsh3.Text = "Error R2 не число!";
                }
            }
            else
            {
                V3.Text = "Error R1 не число!";
                Sbok3.Text = "Error R1 не число!";
                Sosn3.Text = "Error R1 не число!";
                Sosn13.Text = "Error R1 не число!";
                Sobsh3.Text = "Error R1 не число!";
            }
        }
    }
}
