﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SAE_Sujet2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void lancementApplication(object sender, StartupEventArgs args)
        {
            ApplicationData.loadApplicationData();
        }
    }
}
