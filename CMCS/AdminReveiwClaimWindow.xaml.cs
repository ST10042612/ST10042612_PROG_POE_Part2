using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Azure.Data.Tables;

namespace CMCS
{
    
    public partial class AdminReveiwClaimWindow : Window
    {

        private string ConnectionString = "DefaultEndpointsProtocol=https;AccountName=unicourses;AccountKey=7JUPMBcK1VU6rCk7FzRYdSOPjnBSQWyjIZtibobMJN44Qh/VXjKzcnr0gJsxYo4Tu30OPVgGcf2w+ASt68rkKg==;EndpointSuffix=core.windows.net";
        private string TableName = "Claims";
        private TableClient tableClient;
        private List<Claim> claims;

        public AdminReveiwClaimWindow()
        {
            InitializeComponent();
            tableClient = new TableClient(ConnectionString, TableName);
            LoadClaimsAsync();
        }

        private async Task LoadClaimsAsync()
        {
            claims = new List<Claim>();

            await foreach (var claim in tableClient.QueryAsync<Claim>())
            {
                claims.Add(claim);
            }

            ClaimsDataGrid.ItemsSource = claims;
        }
        private void ClaimsDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            AcceptBtn.IsEnabled = ClaimsDataGrid.SelectedItem != null;
            RejectBtn.IsEnabled = ClaimsDataGrid.SelectedItem != null;
        }


        //Button Functionallities

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            CloseAllWindows();
        }
        private void CloseAllWindows()// https://www.codeproject.com/Questions/118479/Open-a-window-and-close-all-other-in-WPF
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 1; intCounter--)
                App.Current.Windows[intCounter].Close();
        }

        private void AcceptBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RejectBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }



    }
}
