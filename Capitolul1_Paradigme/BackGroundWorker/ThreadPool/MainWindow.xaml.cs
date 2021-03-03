using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Xml;
using Microsoft.Win32;

namespace ThreadPoolSample
{
    class ThreadInfo
    {
        public string FileName { get; set; }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        volatile HashSet<String> outval = new HashSet<String>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

            if (fd.ShowDialog() == true)
            {
                ThreadInfo threadInfo = new ThreadInfo();
                threadInfo.FileName = fd.FileName;

                ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessFile), threadInfo);
                ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessFile), threadInfo);

            }

        }

        void ProcessFile(object a)
        {
            XmlDocument parsedStream = new XmlDocument();
            parsedStream.Load(((ThreadInfo)a).FileName);
            XmlNodeList nodes = parsedStream.DocumentElement.SelectNodes("T");
            string strnodes = "";
            this.Dispatcher.Invoke((Action)(() =>
            {
                lstBox.Items.Clear();
            }));
            int count = 0;
            foreach (XmlNode node in nodes)
            {
                string str = "";
                foreach (string s in new String[] { "O_ORDERKEY", "O_TOTALPRICE", "O_ORDERDATE" })
                {
                    str += node.SelectSingleNode(s).InnerText + "\t\t";
                }
                this.Dispatcher.Invoke((Action)(() =>
                {
                    lstBox.Items.Add(str);
                    count++;
                    this.prgbar.Value = count * 100 / nodes.Count;
                    outval.Add(Thread.CurrentThread.ManagedThreadId.ToString());
                    this.no_of_threads.Content += outval.ToString();
                }));

            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
