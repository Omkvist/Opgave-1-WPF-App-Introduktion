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
using WpfAppIntroduktion.BIZ;

namespace WpfAppIntroduktion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ classBIZ = new ClassBIZ();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpg12_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave12(ListBoxRes);
        }

        private void ButtonOpg13_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave13(ListBoxRes);
        }

        private void ButtonOpg14_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave14(ListBoxRes);
        }

        private void ButtonOpg14_Click_1(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave14(ListBoxRes);
        }

        private void ButtonOpg15_Click(object sender, RoutedEventArgs e)
        {
            classBIZ.Delopgave15(ListBoxRes);
        }
    }
}
