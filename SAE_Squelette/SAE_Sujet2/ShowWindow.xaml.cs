using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SAE_Sujet2
{
    /// <summary>
    /// Logique d'interaction pour ShowWindow.xaml
    /// </summary>
    public partial class ShowWindow : Window
    {
        public ShowWindow()
        {
            InitializeComponent();
            ApplicationData.loadApplicationData();

            lvMission.ItemsSource = ApplicationData.listeCorpsArmees;
            dgSalarie.ItemsSource = ApplicationData.listeMissions;

            this.DataContext = this;
        }

        private void butRetour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
