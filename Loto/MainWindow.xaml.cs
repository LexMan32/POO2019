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

namespace Loto
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            sp_tirages.Children.Add(new Tirage(sp_tirages.Children.Count + 1));
        }

        private void supBtn_Click(object sender, RoutedEventArgs e)
        {
            sp_tirages.Children.RemoveAt(sp_tirages.Children.Count - 1);
        }

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {
            sp_tirages.Children.Clear();
        }
    }
}
