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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCustomRoutedEvent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EventProgram evt;
        public MainWindow()
        {
            InitializeComponent();
            evt = new EventProgram();
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            atext.Text = "";
            atext.Text += evt.callEvent(@"c:\Program Files\Java\jdk1.8.0_161\bin\A.java");
        }
    }
}
