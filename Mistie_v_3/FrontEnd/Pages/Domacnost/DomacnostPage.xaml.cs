using Mistie_v_3.BackEnd;
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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//zkouším časovač
using System.Timers;
//zkouším časovač


namespace Mistie_v_3.FrontEnd.Pages
{
    /// <summary>
    /// Interakční logika pro DomacnostPage.xaml
    /// </summary>
    public partial class DomacnostPage : Page
    {
        //PAGES
        MainWindow mainWindow;

        SpravceZabezpeceni spravceZabezpeceni;


        //CLASS
        SpravceCidel spravceCidel;



        public DomacnostPage(MainWindow mainWindow, SpravceCidel spravceCidel, SpravceZabezpeceni spravceZabezpeceni)
        {
            this.mainWindow = mainWindow;
            this.spravceCidel = spravceCidel;
            this.spravceZabezpeceni = spravceZabezpeceni;

            InitializeComponent();
        }

        private void nextFrameButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.DomacnostPage2();
        }
        private void hudbaButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.HudbaPage1();
        }

        private void svetlaButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaPage1();
        }

        private void collectionButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.DomacnostCollectionPage1();
        }

        private void prichodDomuButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.PrichodDomuAktivovat();
            mainWindow.AktivitaButtonu();
        }

        private void odchodZDomuButton_Click(object sender, RoutedEventArgs e)
        {
            spravceZabezpeceni.OdchodZDomuAktivovat();
            mainWindow.AktivitaButtonu();
        }
        private void spanekButton_Click(object sender, RoutedEventArgs e)
        {
            spravceZabezpeceni.SleepAktivovat();
            mainWindow.AktivitaButtonu();
        }
    }
}
