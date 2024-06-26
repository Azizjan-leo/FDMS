﻿using FDMS.BL.Entities;
using FDMS.UI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FDMS.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Staff_Click(object sender, RoutedEventArgs e)
        {
            var workersView = new WorkersView();
            workersView.Show();
        }

        private void Positions_Click(object sender, RoutedEventArgs e)
        {
            var positionsView = new PositionsView();
            positionsView.Show();
        }
    }
}
