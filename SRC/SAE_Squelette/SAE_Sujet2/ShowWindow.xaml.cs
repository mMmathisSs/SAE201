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
            lvDivision.ItemsSource = ApplicationData.listeDivisions;
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
                List<Division> temp2 = new List<Division>();
                foreach (Division uneDivision in ApplicationData.listeDivisions)
                {
                    foreach (Mission uneMission in ApplicationData.listeMissions)
                    {
                        if ((((CorpsArmee)this.lvCorpsArmee.SelectedItem).IdCorpsArmee) == uneDivision.IdCorpsArmee && uneDivision.IdDivision == uneMission.IdDivision)
                        {
                            int compteur = 0;
                            temp.Add(uneMission);
                            foreach (Division truc in temp2)
                            {
                                if (truc == uneDivision)
                                    compteur++;
                            }
                            if (compteur == 0)
                                temp2.Add(uneDivision);
                        }
                    }
                }
                lvDivision.ItemsSource = temp2;
                dgSalarie.ItemsSource = temp;
            }

            if (this.lvDivision.SelectedItem != null)
            {
                List<Mission> temp = new List<Mission>();
                foreach (CorpsArmee unCorpsArmee in ApplicationData.listeCorpsArmees)
                {
                    foreach (Mission uneMission in ApplicationData.listeMissions)
                    {
                        if (unCorpsArmee.IdCorpsArmee == (((Division)this.lvDivision.SelectedItem).IdCorpsArmee) && (((Division)this.lvDivision.SelectedItem).IdDivision) == uneMission.IdDivision)
                            temp.Add(uneMission);
                    }
                }
                dgSalarie.ItemsSource = temp;
            }

            if (this.lvCorpsArmee.SelectedItem is null && this.lvDivision.SelectedItem is null)
            {
                lvDivision.ItemsSource = ApplicationData.listeDivisions;
                dgSalarie.ItemsSource = ApplicationData.listeMissions;
            }
        }

        private void ButSuppr_Click(object sender, RoutedEventArgs e)
        {
            if (this.dgSalarie.SelectedItem == null)
                MessageBox.Show("Sélectionner une affectation", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer ?", "Attention", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
                {
                    ((Mission)this.dgSalarie.SelectedItem).Delete();
                    MessageBox.Show("L'affectation a bien été supprimé !", "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                    ShowWindow showWindow = new ShowWindow();
                    showWindow.ShowDialog();
                }
            }
        }

        private void ButModif_Click(object sender, RoutedEventArgs e)
        {
            if (this.dgSalarie.SelectedItem == null)
                MessageBox.Show("Sélectionner une affectation", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                ModifWindow modifWindow = new ModifWindow(((Mission)this.dgSalarie.SelectedItem));
                modifWindow.ShowDialog();
                this.Close();
            }
        }
    }
}
