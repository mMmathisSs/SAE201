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

            lvCorpsArmee.ItemsSource = ApplicationData.listeCorpsArmees;
            dgSalarie.ItemsSource = ApplicationData.listeMissions;

            this.DataContext = this;
        }

        private void butRetour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (this.lvCorpsArmee.SelectedItem != null)
            {
                List<Mission> temp = new List<Mission>();
                foreach (Division uneDivision in ApplicationData.listeDivisions)
                {
                    foreach (Mission uneMission in ApplicationData.listeMissions)
                    {
                        if ((((CorpsArmee)this.lvCorpsArmee.SelectedItem).IdCorpsArmee) == uneDivision.IdCorpsArmee && uneDivision.IdDivision == uneMission.IdDivision)
                            temp.Add(uneMission);
                    }
                }
                dgSalarie.ItemsSource = temp;
            }
            if (this.lvCorpsArmee.SelectedItem is null)
                dgSalarie.ItemsSource = ApplicationData.listeMissions;
        }
    }
}
