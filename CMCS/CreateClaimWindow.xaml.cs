using Microsoft.Win32;
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

namespace CMCS
{
    /// <summary>
    /// Interaction logic for CreateClaimWindow.xaml
    /// </summary>
    public partial class CreateClaimWindow : Window
    {

        private string fileName = "";

        public CreateClaimWindow()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            CloseAllWindows();
            LecturerMainWindow LMW = new LecturerMainWindow();
            LMW.Show();
        }

        private void SubmitClaimBtn_Click(object sender, RoutedEventArgs e)
        {
            CloseAllWindows();
            LecturerMainWindow LMW = new LecturerMainWindow();
            LMW.Show();
        }

        private void UploadDocsBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Please Select a Document",
                Filter = "All Files (*.*)|*.*"
            };

            if (fileDialog.ShowDialog() == true)
            {
                fileName = fileDialog.FileName;
                docNamesTb.Text = fileName;
            }

        }

        private void CloseAllWindows()
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 1; intCounter--)
                App.Current.Windows[intCounter].Close();
        }


    }
}
