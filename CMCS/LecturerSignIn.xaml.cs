﻿using System;
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
    /// Interaction logic for LecturerSignIn.xaml
    /// </summary>
    public partial class LecturerSignIn : Window
    {
        public LecturerSignIn()
        {
            InitializeComponent();
        }

        //button functionalities
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            CloseAllWindows();
            MainWindow MW = new MainWindow();
            MW.Show();
            
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            CloseAllWindows();
            LecturerMainWindow LMW = new LecturerMainWindow();
            LMW.Show();
        }

        private void CloseAllWindows()//Closes all currently open windows https://www.codeproject.com/Questions/118479/Open-a-window-and-close-all-other-in-WPF
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter > 0; intCounter--)
                App.Current.Windows[intCounter].Close();
        }



    }
}
