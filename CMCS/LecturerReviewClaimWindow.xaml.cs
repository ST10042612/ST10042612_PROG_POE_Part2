using Azure.Data.Tables;
using CMCS;
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
    /// Interaction logic for LecturerReviewClaimWindow.xaml
    /// </summary>
    public partial class LecturerReviewClaimWindow : Window
    {

        private string ConnectionString = ""; //empty due to github security restrictions, also it is bad practise to put acess keys into a public/private repository
        private string TableName = "Claims";
        private TableClient tableClient;
        private List<Claim> claims;

        public LecturerReviewClaimWindow()
        {
            InitializeComponent();
            tableClient = new TableClient(ConnectionString, TableName);
            LoadClaimsAsync();
        }

        private async Task LoadClaimsAsync()// will gather all the claims from the Claims Table and display them in a datagrid
        {
            claims = new List<Claim>();

            await foreach (var claim in tableClient.QueryAsync<Claim>())
            {
                claims.Add(claim);
            }

            ClaimsDataGrid.ItemsSource = claims;
        }

        //button functionalities
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            CloseAllWindows();
            LecturerMainWindow LMW = new LecturerMainWindow();
            LMW.Show();
        }
        private void CloseAllWindows()//Closes all currently open windows https://www.codeproject.com/Questions/118479/Open-a-window-and-close-all-other-in-WPF
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 1; intCounter--)
                App.Current.Windows[intCounter].Close();
        }
    }
}
