using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour ModifWindow.xaml
    /// </summary>
    public partial class ModifWindow : Window
    {
        public ModifWindow(Mission mission)
        {
            InitializeComponent();
            cbDivision.ItemsSource = ApplicationData.listeDivisions;
            List<Mission> temp = new List<Mission>();
            temp.Add(mission);
            missionBox.Text = mission.LibelleMission;
            foreach (Division uneDivision in ApplicationData.listeDivisions)
                if (uneDivision.IdDivision == mission.IdDivision)
                    cbDivision.Text = uneDivision.LibelleDivision;
            dpicker.Text = mission.DateAffectation.ToString("dd/MM/yyyy");
            comm.Text = mission.Commentaire;
        }

        private void butAnnuler_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ShowWindow showWindow = new ShowWindow();
            showWindow.ShowDialog();
        }

        private void butModif_Click(object sender, RoutedEventArgs e)
        {
            Mission modifMission = new Mission();
            foreach (Division uneDivision in ApplicationData.listeDivisions)
            {
                foreach (Mission uneMission in ApplicationData.listeMissions)
                {
                    if (uneDivision.LibelleDivision == ((Division)cbDivision.SelectedItem).LibelleDivision && uneMission.LibelleMission == missionBox.Text)
                    {
                        modifMission = new Mission(uneMission.IdMission, uneDivision.IdDivision, missionBox.Text, DateTime.Parse(dpicker.Text), comm.Text);
                        
                    }
                }
            }
            Console.WriteLine(((Division)cbDivision.SelectedItem).LibelleDivision);
            modifMission.Update();
            this.Close();
            ShowWindow showWindow = new ShowWindow();
            showWindow.ShowDialog();
        }
    }
}
