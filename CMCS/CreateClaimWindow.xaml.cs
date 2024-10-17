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
                Filter = "Text Files(*.PDF;*.DOCX;*.XLSX)|*.PDF;*.DOCX;*.XLSX"// https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filter?view=windowsdesktop-8.0
            };

            if (fileDialog.ShowDialog() == true)
            {
                fileName = fileDialog.FileName;
                docNamesTb.Text = fileName;//https://learn.microsoft.com/en-us/dotnet/desktop/wpf/controls/how-to-set-the-text-content-of-a-textbox-control?view=netframeworkdesktop-4.8
            }

        }

        private void CloseAllWindows()// https://www.codeproject.com/Questions/118479/Open-a-window-and-close-all-other-in-WPF
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 1; intCounter--)
                App.Current.Windows[intCounter].Close();
        }


    }
}
