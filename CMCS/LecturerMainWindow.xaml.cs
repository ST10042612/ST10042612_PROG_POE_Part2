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
    /// Interaction logic for LecturerMainWindow.xaml
    /// </summary>
    public partial class LecturerMainWindow : Window
    {
        public LecturerMainWindow()
        {
            InitializeComponent();
        }

        private void ReviewClaimsBtn_Click(object sender, RoutedEventArgs e)
        {
            CloseAllWindows();
            LecturerReviewClaimWindow LRCW = new LecturerReviewClaimWindow();
            LRCW.Show();
        }

        private void CreateClaimBtn_Click(object sender, RoutedEventArgs e)
        {
            CloseAllWindows();
            CreateClaimWindow CCW = new CreateClaimWindow();
            CCW.Show();
        }

        private void CloseAllWindows()// https://www.codeproject.com/Questions/118479/Open-a-window-and-close-all-other-in-WPF
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 1; intCounter--)
                App.Current.Windows[intCounter].Close();
        }

    }
}
