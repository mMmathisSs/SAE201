using SAE_Squelette;
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
        public ObservableCollection<Mission> LesMissions { get; set; }
        public object ApplicationData { get; }

        public ShowWindow()
        {
            InitializeComponent();
            LesMissions = new ObservableCollection<Mission>();
            LesMissions.Add(new Mission("Mission 1", new DateTime(01,01,01)));
            LesMissions.Add(new Mission("Mission 2", new DateTime(01, 01, 01)));
            LesMissions.Add(new Mission("Mission 3", new DateTime(01, 01, 01)));
            LesMissions.Add(new Mission("Mission 4", new DateTime(01, 01, 01)));
            LesMissions.Add(new Mission("Mission 5", new DateTime(01, 01, 01)));
            this.DataContext = this;
            //lvMission.ItemsSource = ApplicationData.LesMissions;
        }

        private void butRetour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
