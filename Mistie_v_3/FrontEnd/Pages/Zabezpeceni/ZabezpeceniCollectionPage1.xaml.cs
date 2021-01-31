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
    /// Interakční logika pro ZabezpeceniCollectionPage1.xaml
    /// </summary>
    public partial class ZabezpeceniCollectionPage1 : Page
    {
        MainWindow mainWindow;
        public ZabezpeceniCollectionPage1(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void zpetButton_Click(object sender, RoutedEventArgs e)
        {
            //this.NavigationService.Navigate(zabezpeceniPage);
        }
        private void aktivovatZabezpeceniButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.AktivitaButtonu();
        }
    }
}
