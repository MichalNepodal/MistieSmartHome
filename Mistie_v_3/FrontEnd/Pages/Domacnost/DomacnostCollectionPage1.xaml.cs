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
    /// Interakční logika pro DomacnostCollectionPage1.xaml
    /// </summary>
    public partial class DomacnostCollectionPage1 : Page
    {
        MainWindow mainWindow;
        SpravceCidel spravceCidel;

        public DomacnostCollectionPage1(MainWindow mainWindow, SpravceCidel spravceCidel)
        {
            this.spravceCidel = spravceCidel;
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void PraceCollectionButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.CollectionPracovnaPrace();
            mainWindow.AktivitaButtonu();
        }
        private void zpetButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.HomePage1();
            mainWindow.AktivitaButtonu();
        }
        private void hudbaButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
