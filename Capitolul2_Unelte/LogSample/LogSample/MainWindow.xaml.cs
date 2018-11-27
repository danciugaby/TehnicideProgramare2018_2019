using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace LogSample
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
            OpenFileDialog fd = new OpenFileDialog();
            try
            {
                if (fd.ShowDialog() == true)
                {

                    StreamReader fr = new StreamReader(fd.FileName + "lala");
                    String s;
                    while ((s = fr.ReadLine()) != null)
                    {
                        txtStuff.Text += s + Environment.NewLine;
                    }
                }
            }
            catch (Exception ex)
            {
                Constants.Logger.Error("Error at reading file " + fd.FileName, ex);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Constants.Logger.Info("App has been launched at " + DateTime.Now);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Constants.Logger.Info("App has been closed at " + DateTime.Now);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            try
            {
                if (fd.ShowDialog() == true)
                {

                    StreamWriter fr = new StreamWriter(fd.FileName);
                    String s;
                    fr.Write(txtStuff.Text);
                    fr.Flush();
                }
            }
            catch (Exception ex)
            {
                Constants.Logger.Error("Error at writing to file " + fd.FileName, ex);
            }
        }
    }
}
