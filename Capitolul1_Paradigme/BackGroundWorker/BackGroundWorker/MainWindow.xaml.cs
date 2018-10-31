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
using Microsoft.Win32;
using System.IO;
using System.Xml;
using System.ComponentModel;

namespace BackGroundWorker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        string filepath;
        List<String> lines;
        public MainWindow()
        {
            InitializeComponent();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
            this.backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            filepath = "";
            lines = new List<string>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

            if (fd.ShowDialog() == true)
            {
                filepath = fd.FileName;
                prgbar.Value = 0;
                backgroundWorker.RunWorkerAsync();
            }
        }
        void ParseXMLOnDifferentThread(string filepath, string mainnode, string[] innernodes)
        {

        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            XmlDocument parsedStream = new XmlDocument();
            parsedStream.Load(filepath);
            XmlNodeList nodes = parsedStream.DocumentElement.SelectNodes("T");

            lines.Clear();
            int count = 0;

            foreach (XmlNode node in nodes)
            {
                string str = "";
                foreach (string s in new String[] { "O_ORDERKEY", "O_TOTALPRICE", "O_ORDERDATE" })
                {
                    str += node.SelectSingleNode(s).InnerText + "\t\t";
                }
                lines.Add(str);
                if (backgroundWorker.CancellationPending == true)
                {
                    backgroundWorker.CancelAsync();
                    return;
                }
                count++;
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker.ReportProgress(0); //here we raise event backgroundWorker_ProgressChanged
                    return;
                }
                this.backgroundWorker.ReportProgress(count * 100 / nodes.Count); //here we raise event backgroundWorker_ProgressChanged
                this.Dispatcher.Invoke((Action)(() =>
                {
                    this.UpdateLayout();
                }
             ));
            }


        }
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Dispatcher.BeginInvoke((Action)(() =>
            {
                lstBox.Items.Clear();
                foreach (string s in lines)
                {
                    lstBox.Items.Add(s);
                }
            }
            ));

        }
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Dispatcher.BeginInvoke((Action)(() =>
            {
                this.prgbar.Value = e.ProgressPercentage;              
            }
             ));
        }

        void ParseXML(string filepath, string mainnode, string[] innernodes)
        {
            XmlDocument parsedStream = new XmlDocument();
            parsedStream.Load(filepath);
            XmlNodeList nodes = parsedStream.DocumentElement.SelectNodes(mainnode);
            string strnodes = "";
            lstBox.Items.Clear();
            foreach (string s in innernodes)
            {
                strnodes += s + "\t\t";
            }
            lstBox.Items.Add(strnodes);
            foreach (XmlNode node in nodes)
            {
                string str = "";
                foreach (string s in innernodes)
                {
                    str += node.SelectSingleNode(s).InnerText + "\t\t";
                }
                lstBox.Items.Add(str);

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }

        }
    }
}
