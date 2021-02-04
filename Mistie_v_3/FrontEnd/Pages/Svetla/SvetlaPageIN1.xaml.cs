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
    /// Interakční logika pro SvetlaPageIN1.xaml
    /// </summary>
    public partial class SvetlaPageIN1 : Page
    {
        // CLASS
        SpravceCidel spravceCidel;
        // PAGES
        MainWindow mainWindow;
        




        public SvetlaPageIN1(MainWindow mainWindow, SpravceCidel spravceCidel)
        {
            this.spravceCidel = spravceCidel;
            this.mainWindow = mainWindow;
            
            //svetlaPracovnaPage1 = new SvetlaPracovnaPage1(this);
            InitializeComponent();
        }

        private void obyvakSvetlaButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaObyvakPage1();
        }
        private void pracovnaSvetlaButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaPracovnaPage1();
        }
        private void KoupelnaSvetlaButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaKoupelnaPage1();
        }
        private void kuchynSvetlaButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaKuchynPage1();
        }
        private void lozniceSvetlaButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaLoznicePage1();
        }
        private void zpetButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaPage1();
        }
        private void chodbaSvetlaButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaChodbaPage1();
        }
    }
}
