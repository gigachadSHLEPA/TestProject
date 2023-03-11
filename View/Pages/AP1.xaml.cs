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
using TestProject.Core;

namespace TestProject.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AP1.xaml
    /// </summary>
    public partial class AP1 : Page
    {
        public AP1()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbF2.Text);
                double a1 = 0.2;
                double a2 = 0.15;
                    double a3 = 0.9;
                double b1 = 0.5;
                double b2 = 0.2;
                double b3 = 5;
                double z1 = Math.Exp(a1 * x);
                    double z2 = Math.Exp(2*a2 * x);
                    double z3 = Math.Exp(2.5*a3 * x);
                if (x < Math.Log10(a1))
                {
                    MessageBox.Show($"y = {a1 * Math.Pow(Math.Sin(x), 2) + b1 * Math.Cos(z1 * x)}");
                }
                if ( x >= -Math.Log10(a2) && x <= b1)
                {
                    MessageBox.Show($"y = {Math.Pow(a2, b2) - Math.Pow(Math.Cos(a2 + z2 * x),3)}");
                }
                if (x > b3)
                    {
                        MessageBox.Show($"y = {Math.Pow(Math.Sqrt(2.5 * Math.Pow(a3,3) + (b3 - z3 * Math.Pow(x,2))), 6)}");
                    }
                
            }
            catch
            {
                MessageBox.Show($"ВЫХОДИ ОТСЮДА, А ТО ЗАРЕЖУ!! ААААААААААААААААА!!! *агрессивно достает нож*");
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            TestCoreFR.MyCore?.Navigate(new MainPage());
        }
    }
}
