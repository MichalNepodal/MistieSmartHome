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
    /// Interakční logika pro DomacnostCollectionPage2.xaml
    /// </summary>
    public partial class DomacnostCollectionPage2 : Page
    {
        MainWindow mainWindow;

        public DomacnostCollectionPage2(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void zpetButton_Click(object sender, RoutedEventArgs e)
        {
            //this.NavigationService.Navigate(domacnostCollectionPage1);
            mainWindow.AktivitaButtonu();
        }

        private void hudbaButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
