﻿using Audio_Player___MVVM.ViewModels;
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
using System.Windows.Shapes;

namespace Audio_Player___MVVM.Views
{
    /// <summary>
    /// Логика взаимодействия для PlayerWindow.xaml
    /// </summary>
    public partial class PlayerWindow : Window
    {
        public PlayerWindow()
        {
            InitializeComponent();
            var viewModel = new PlayerViewModel(this, mediaElement);
            DataContext = viewModel;

            MinHeight = 450;
            MinWidth = 650;
        }
    }
}