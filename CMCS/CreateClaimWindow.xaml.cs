using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace CMCS
{
    /// <summary>
    /// Interaction logic for CreateClaimWindow.xaml
    /// </summary>
    public partial class CreateClaimWindow : Window
    {
        //variable declaration
        private string fileName = "";

        public CreateClaimWindow()
        {
            InitializeComponent();
        }

        //button funcionalities
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
                Filter = "Text Files(*.PDF;*.DOCX;*.XLSX)|*.PDF;*.DOCX;*.XLSX"//Fileters what files can be submited https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filter?view=windowsdesktop-8.0
            };

            try//try catch block for exeption handeling
            {
                if (fileDialog.ShowDialog() == true)// displays a new file dialog
                {
                    fileName = fileDialog.FileName;
                    docNamesTb.Text = fileName;//This will display the files name in a text box https://learn.microsoft.com/en-us/dotnet/desktop/wpf/controls/how-to-set-the-text-content-of-a-textbox-control?view=netframeworkdesktop-4.8
                }
            }
            catch (FileNotFoundException) //catches an exeption if a file cannot be found
            {
                ErrorPopup EP = new ErrorPopup();
                EP.Show();
            }
            catch(Exception) // handels general errors if they do occur
            {
                ErrorPopup EP = new ErrorPopup();
                EP.Show();
            }
               

        }

        private void CloseAllWindows()//Closes all currently open windows https://www.codeproject.com/Questions/118479/Open-a-window-and-close-all-other-in-WPF
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 1; intCounter--)
                App.Current.Windows[intCounter].Close();
        }


    }
}
