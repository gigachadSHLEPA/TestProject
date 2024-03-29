﻿using System;
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
    /// Логика взаимодействия для AP3.xaml
    /// </summary>
    public partial class AP3 : Page
    {
        public AP3()
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
                double a1 = -5;
                double a2 = 3;
                double a3 = -10;
                double b1 = 5.3;
                double b2 = 1.8;
                double b3 = -0.6;
                double z1 = Math.Log10(Math.Abs(b1 * Math.Pow(x, 3)));
                double z2 = Math.Log10(Math.Abs(b2 * x));
                double z3 = Math.Log10(Math.Abs(b3 * Math.Pow(x,2)));
                if (x < a1)
                {
                    MessageBox.Show($"y = {2.8 * Math.Pow(Math.Sin(a1 * x),2) - b1 * Math.Pow(x,3) * z1}");
                }
                if (x >= a2 && x <= Math.Pow(b2,2))
                {
                    MessageBox.Show($"y = {z2 * Math.Pow(Math.Cos(a2 * x + b2), 2) +  Math.Log10(z2)}");
                }
                if (x > Math.Pow(b3,2))
                {
                    MessageBox.Show($"y = {Math.Exp(2.5 * a3 * x) + z3 * a3 * b3 * x}");
                }

            }
            catch
            {
                MessageBox.Show($"ВЫХОДИ ОТСЮДА, А ТО ЗАРЕЖУ!! ААААААААААААААААА!!! *агрессивно достает нож*");
            }
        }
    }
}
