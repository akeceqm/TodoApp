﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoApp
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

        private void FullScreenWindow()
        {
            if (WindowState == WindowState.Maximized)
            {
                borderWindowScreen.CornerRadius = new CornerRadius(10);
                WindowState = WindowState.Normal;
            }
            else
            {
                borderWindowScreen.CornerRadius = new CornerRadius(0);
                WindowState = WindowState.Maximized;
            }
        }

        private void borderClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void borderHide_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void borderInFullScreen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FullScreenWindow();
        }

        private void moveWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                FullScreenWindow();
            }
            else
            {
                DragMove();
            }
        }
    }
}