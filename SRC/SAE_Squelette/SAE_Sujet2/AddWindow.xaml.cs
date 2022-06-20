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
    /// Logique d'interaction pour AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
            ApplicationData.loadApplicationData();
            cbDivision.ItemsSource = ApplicationData.listeDivisions;
            cbMission.ItemsSource = ApplicationData.listeMissions;
            this.DataContext = this;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbDivision_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Add_Click(object sender, RoutedEventArgs e)
        {
            // Variable de validation
            int cntError = 0;
            string formatted = "";

            // Tests
            if (cbDivision.Text == "")
            {
                DivisionErrorLabel.Visibility = Visibility.Visible;
                cntError++;
            }
            else
                DivisionErrorLabel.Visibility = Visibility.Hidden;
            if (cbMission.Text == "")
            {
                MissionErrorLabel.Visibility = Visibility.Visible;
                cntError++;
            }
            else
                MissionErrorLabel.Visibility = Visibility.Hidden;
            if (dpicker.SelectedDate == null)
            {
                DatePickerErrorLabel.Visibility = Visibility.Visible;
                cntError++;
            }
            else
            {
                DatePickerErrorLabel.Visibility = Visibility.Hidden;
                DateTime? selectedDate = dpicker.SelectedDate;
                formatted = selectedDate.Value.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            if (cntError == 0)
            {
                Mission addMission = new Mission(1, ((Division)cbDivision.SelectedItem).IdDivision, ((Mission)cbMission.SelectedItem).LibelleMission, DateTime.Parse(formatted), tbAdd.Text);
                addMission.Create();
                MessageBox.Show("L'affectation a bien été ajouté !", "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Des erreurs sont présentes lors de la saisie", "Attention", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            
            
        }
    }
}
