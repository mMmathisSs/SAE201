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



            DateTime? selectedDate = dpicker.SelectedDate;
            string formatted = selectedDate.Value.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Mission addMission = new Mission(1, ((Division)cbDivision.SelectedItem).IdDivision, MissionBox.Text, DateTime.Parse(formatted), tbAdd.Text);
            addMission.Create();
            this.Close();
            
        }
    }
}
