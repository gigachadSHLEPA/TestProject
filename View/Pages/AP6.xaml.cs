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
    /// Логика взаимодействия для AP6.xaml
    /// </summary>
    public partial class AP6 : Page
    {
        public AP6()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            TestCoreFR.MyCore?.Navigate(new MainPage());
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbF2.Text);
                double a1 = 1.2;
                double a2 = -1.5;
                double a3 = 1.7;
                double b1 = 7.2;
                double b2 = 3.2;
                double b3 = 5.5;
                double z1 = Math.Exp(x);
                double z2 = Math.Exp(2*x);
                double z3 = Math.Exp(3);
                if (x < Math.Pow(a1,3))
                {
                    MessageBox.Show($"y = {a1 * Math.Pow(Math.Sin(x),2) + b1 * Math.Cos(z1 * x + a1)}");
                }
                if (x >= Math.Pow(a1, 3) && x <= b2 )
                {
                    MessageBox.Show($"y = {Math.Pow(a2 + b2 * x,2) - Math.Sin(a2 + z2 * x) }");
                }
                if (x > b3)
                {
                    MessageBox.Show($"y = {Math.Sqrt(x - (Math.Sin(b3 * x + z3)))}");
                }

            }
            catch
            {
                MessageBox.Show($"ВЫХОДИ ОТСЮДА, А ТО ЗАРЕЖУ!! ААААААААААААААААА!!! *агрессивно достает нож*");
            }
        }
    }
}
