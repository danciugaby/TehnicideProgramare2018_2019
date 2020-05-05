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
using System.Runtime.InteropServices;

namespace GUIFrameWork2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _path;
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

        public MainWindow()
        {
           //MessageBox(System.IntPtr.Zero,"ceva","title",0);
           InitializeComponent();
        }
        #region methods
        private void SetImageData(byte[] data)
        {
            var source = new BitmapImage();
            source.BeginInit();
            source.StreamSource = new MemoryStream(data);
            source.EndInit();

            this.workingImage.Source = source;
        }
        private string GetSelectedFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files | *.jpg;*.bmp;*.png";
            Nullable<bool> result = ofd.ShowDialog();
            string selectedFile="";
            if (result.HasValue == true && result.Value == true)
            {
                selectedFile = ofd.FileName;
            }
            return selectedFile;
        }
        #endregion
        #region events
        private void btnChooseImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _path = GetSelectedFile();
                byte[] arrayofbytes = File.ReadAllBytes(_path);
                SetImageData(arrayofbytes);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

        }

        private void btnProcessImage_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Image Files | *.jpg;*.bmp;*.png";
            Nullable<bool> result = sfd.ShowDialog();
            string selectedFile = "";
            if (result.HasValue == true && result.Value == true)
            {
                selectedFile = sfd.FileName;
            }

            this.processedImage.Source = Intermediate.Mapper.ProcessAndSaveImage(_path,selectedFile);
        }
        #endregion
    }
}
