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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mistie_v_3.FrontEnd.Pages.Home
{
    /// <summary>
    /// Interaction logic for HomePage1.xaml
    /// </summary>
    public partial class HomePage1 : Page
    {
        SpravceCidel spravceCidel;
        BackGroundProcesy backGroundProcesy;
        SpravceZabezpeceni spravceZabezpeceni;
        MainWindow mainWindow;
        
        public HomePage1(SpravceCidel spravceCidel, BackGroundProcesy backGroundProcesy, MainWindow mainWindow, SpravceZabezpeceni spravceZabezpeceni)
        {
            this.mainWindow = mainWindow;
            this.spravceZabezpeceni = spravceZabezpeceni;
            this.backGroundProcesy = backGroundProcesy;
            this.spravceCidel = spravceCidel;
            OdesliSeBackgrount();
            InitializeComponent();
        }

        public void AktualizovatTeplotu()
        {
            teplotaINTextBlock.Text = spravceCidel.VratTeplotu().ToString() + " °C";
        }

        // BUTTONS    BUTTONS
        // BUTTONS    BUTTONS
        private void kolekceButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.DomacnostCollectionPage1();
        }

        private void svetlaButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaPage1();
        }

        private void spanekButton_Click(object sender, RoutedEventArgs e)
        {
            spravceZabezpeceni.SleepAktivovat();
            mainWindow.AktivitaButtonu();
        }

        private void youtubeButton_Click(object sender, RoutedEventArgs e)
        {
            // mainWindow.WebPage1();
            mainWindow.AktivitaButtonu();
        }
        private void hudbaButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.HudbaPage1();
        }

        // METODA PŘI BUILDU
        private void OdesliSeBackgrount()
        {
            backGroundProcesy.NactiHomePage1(this);
        }

        private void odchodButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.OdchodZDomuAktivovat("on");
            mainWindow.AktivitaButtonu();
        }
    }
}
