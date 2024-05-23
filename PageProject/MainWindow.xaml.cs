﻿using System.Windows;
using PageProject.Models;
using PageProject.ViewModels;
using PageProject.Views;

namespace PageProject
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AggregateModel AM = new AggregateModel();

            AggregateViewModel AVM = new AggregateViewModel(AM);
            
            AggregateView AV = new AggregateView(AVM);
            AV.ShowDialog();

        }

    }
}