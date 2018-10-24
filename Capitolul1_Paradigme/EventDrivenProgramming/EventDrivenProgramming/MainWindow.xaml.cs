using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace EventDrivenProgramming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MouseUp += new MouseButtonEventHandler(MouseUpEvent);
            //...
            
            
        }
        
        private void MouseUpEvent(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Clicked at X:" + e.GetPosition(this).X + " Y:"  + e.GetPosition(this).Y);
        }
        private delegate void UpdateSomeControl(TextBlock control, String value);

        private void UpdateTextControl(TextBlock control, String value)
        {
            var dispatcher = Application.Current.MainWindow.Dispatcher;

            Dispatcher.BeginInvoke(new Action(() =>
            {
                control.Text = "";
                System.Threading.Thread.Sleep(1000);
                control.Text = value;
            }), DispatcherPriority.Background);

            control.Text += " AfterUpdate";
            

        }      

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            UpdateTextControl(txt2, "Click event is bubbled to StackPanel");
            e.Handled = true;
        }

      

        private void Window_Click(object sender, RoutedEventArgs e)
        {
            UpdateTextControl(txt3, "Click event is bubbled to Window");
            
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpdateTextControl(txt1, "Button clicked");
           
        }
    }
}
