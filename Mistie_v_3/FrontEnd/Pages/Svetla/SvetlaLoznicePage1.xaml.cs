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
    /// Interakční logika pro SvetlaLoznicePage1.xaml
    /// </summary>
    public partial class SvetlaLoznicePage1 : Page
    {
        MainWindow mainWindow;
        SpravceCidel spravceCidel;

        public SvetlaLoznicePage1(MainWindow mainWindow, SpravceCidel spravceCidel)
        {
            this.mainWindow = mainWindow;
            this.spravceCidel = spravceCidel;
            InitializeComponent();
        }


        private void zapnoutVsechnaSvetlaButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.SvetlaIN("Loznice", "", "on");
            mainWindow.AktivitaButtonu();
        }
        private void vypnoutVsechnaSvetlaButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.SvetlaIN("loznice", "", "off");
            mainWindow.AktivitaButtonu();
        }
        private void svetlaLustrButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.SvetlaINAuto("loznice", "lustr");
            mainWindow.AktivitaButtonu();
        }
        private void zpetButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaPageIN1();
        }
    }
}
