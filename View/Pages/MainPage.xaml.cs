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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestCoreFR.MyCore?.Navigate(new AP1());
        }
        void MediaElement_MediaEnded(object sender, EventArgs e)
        {
            MediaElement mediaElement = (MediaElement)sender;
            mediaElement.Stop();
            mediaElement.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TestCoreFR.MyCore?.Navigate(new AP2());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TestCoreFR.MyCore?.Navigate(new AP3());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TestCoreFR.MyCore?.Navigate(new AP4());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TestCoreFR.MyCore?.Navigate(new AP5());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TestCoreFR.MyCore?.Navigate(new AP6());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TestCoreFR.MyCore?.Navigate(new AP7());
        }
    }
}
