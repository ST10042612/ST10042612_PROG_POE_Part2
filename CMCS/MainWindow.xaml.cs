using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CMCS
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

        private void AdminBtn_Click(object sender, RoutedEventArgs e)
        {
            CloseAllWindows();
            AdminSignIn ASI = new AdminSignIn();
            this.Hide();
            ASI.Show();
        }

        private void LBtn_Click(object sender, RoutedEventArgs e)
        {
            CloseAllWindows();
            LecturerSignIn LSI = new LecturerSignIn();
            this.Hide();
            LSI.Show();
            
        }

        private void CloseAllWindows()
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 1; intCounter--)
                App.Current.Windows[intCounter].Close();
        }

    }
}