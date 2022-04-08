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

namespace VuesVSC
{
    /// <summary>
    /// Interaction logic for ArmePassiveControl.xaml
    /// </summary>
    public partial class UCArmesPassives : UserControl
    {
        public UCArmesPassives()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCArmePassive();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCArmeActive();
        }
    }
}