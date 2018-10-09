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

namespace ParallelLoading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    struct AStruct
    {
        public XmlNodeList nodes;
        public int index;
    }
    public partial class MainWindow : Window
    {
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
                XmlDocument parsedStream = new XmlDocument();
                parsedStream.Load(fd.FileName);
                XmlNodeList nodes = parsedStream.DocumentElement.SelectNodes("T");
                lstBox.Items.Clear();

                Thread[] threads = new Thread[4];
                AStruct[] structs = new AStruct[4];
                for (int i = 0; i < threads.Count(); i++)
                {
                    ParameterizedThreadStart pm = new ParameterizedThreadStart(LoadXML);
                    threads[i] = new Thread(pm);
                    structs[i] = new AStruct();
                    structs[i].index = i;
                    structs[i].nodes = nodes;                   
                }
                
                for (int i = 0; i < threads.Count(); i++)
                {
                    System.Threading.Thread.Sleep(10);
                    threads[i].Start(structs[i]);
                }

            }
        }
        public void LoadXML(object o)
        {
            AStruct s = (AStruct)o;
            int lowerlimit = (s.nodes.Count * s.index) / 4;
            int upperlimit = (s.nodes.Count * (s.index + 1)) / 4;
            this.Dispatcher.Invoke((Action)(() =>
            {
                txtresult.Text += "In thread " + s.index + " lower = " + lowerlimit + " upper  = " + upperlimit + Environment.NewLine;
            }));
            for (int t = lowerlimit; t < upperlimit; t++)
            {
                XmlNode node = s.nodes[t];
                if (node == null)
                    continue;
                string str = "";
                foreach (string st in new String[] { "O_ORDERKEY", "O_TOTALPRICE", "O_ORDERDATE" })
                {
                    str += node.SelectSingleNode(st).InnerText + "\t\t";
                }
                this.Dispatcher.Invoke((Action)(() =>
                {
                    lstBox.Items.Add(str);

                }));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
