﻿using Mistie_v_3.BackEnd;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mistie_v_3.FrontEnd.Pages
{
    /// <summary>
    /// Interakční logika pro SvetlaPokoj2Page1.xaml
    /// </summary>
    public partial class SvetlaPracovnaPage1 : Page
    {
        MainWindow mainWindow;
        SpravceCidel spravceCidel;

        public SvetlaPracovnaPage1(MainWindow mainWindow, SpravceCidel spravceCidel)
        {
            this.mainWindow = mainWindow;
            this.spravceCidel = spravceCidel;
            InitializeComponent();
        }

        private void zapnoutVsechnaSvetlaButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.SvetlaIN("pracovna", "", "on");
        }
        private void vypnoutVsechnaSvetlaButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.SvetlaIN("pracovna", "", "off");
            mainWindow.AktivitaButtonu();
        }
        private void svetlaLustrButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.SvetlaINAuto("pracovna", "lustr");
            mainWindow.AktivitaButtonu();
        }
        private void zpetButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaPageIN1();
        }
    }
}
