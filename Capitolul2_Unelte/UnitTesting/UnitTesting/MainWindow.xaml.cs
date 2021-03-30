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


namespace UnitTesting
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
            if (Validate("me", "mypass"))
                MessageBox.Show("passed");
            else
                MessageBox.Show("failed");
        }
        public bool Validate(string user, string pass)
        {
            return (user == txtUser.Text && pass == txtPass.Text);
        }

        public void InitControls()
        {
            txtUser.Text = "me";
            txtPass.Text = "mypass";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Arithmetics a = new Arithmetics();
            if (a.Sum(Int32.Parse(txtUser.Text), Int32.Parse(txtPass.Text)) == 3)
                MessageBox.Show("passed");
            else
                MessageBox.Show("failed");
        }

    }
}
