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

namespace Mistie_v_3.FrontEnd.Pages
{
    /// <summary>
    /// Interakční logika pro SvetlaPage1.xaml
    /// </summary>
    public partial class SvetlaPage1 : Page
    {
        MainWindow mainWindow;
        //CLASS
        SpravceCidel spravceCidel;

        public SvetlaPage1(MainWindow mainWindow, SpravceCidel spravceCidel)
        {
            this.mainWindow = mainWindow;
            this.spravceCidel = spravceCidel;
            InitializeComponent();
        }

        private void zapnoutSvetloButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.SvetlaIN("vse", "", "on");
            mainWindow.AktivitaButtonu();
        }
        private void vypnoutSvetloButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.SvetlaIN("vse", "", "off");
            mainWindow.AktivitaButtonu();
        }
        private void svetlaINButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaPageIN1();
        }
        private void svetlaCollectionButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaCollectionPage1();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.DomacnostPage();
        }
        private void zpetButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.HomePage1();
        }
    }
}
