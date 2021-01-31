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
    /// Interakční logika pro CollectionPage1.xaml
    /// </summary>
    public partial class SvetlaCollectionPage1 : Page
    {
        MainWindow mainWindow;
        SpravceCidel spravceCidel;

        public SvetlaCollectionPage1(MainWindow mainWindow, SpravceCidel spravceCidel)
        {
            this.mainWindow = mainWindow;
            this.spravceCidel = spravceCidel;
            InitializeComponent();
        }

        private void relaxTelevizeButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.CollectionRelaxTelevize();
            mainWindow.AktivitaButtonu();
        }
        private void svetlaLampaButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.CollectionPracovnaPrace();
            mainWindow.AktivitaButtonu();
        }
        private void zapnoutVsechnaSvetlaButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.AktivitaButtonu();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaPage1();
        }
    }
}
