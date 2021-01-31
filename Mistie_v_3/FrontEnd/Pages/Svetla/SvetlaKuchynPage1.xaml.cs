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
    /// Interakční logika pro SvetlaKuchynPage1.xaml
    /// </summary>
    public partial class SvetlaKuchynPage1 : Page
    {
        MainWindow mainWindow;
        SpravceCidel spravceCidel;

        public SvetlaKuchynPage1(MainWindow mainWindow, SpravceCidel spravceCidel)
        {
            this.mainWindow = mainWindow;
            this.spravceCidel = spravceCidel;
            InitializeComponent();
        }

        private void zapnoutVsechnaSvetlaButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.SvetlaIN("kuchyn", "", "on");
            mainWindow.AktivitaButtonu();
        }

        private void vypnoutVsechnaSvetlaButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.SvetlaIN("kuchyn", "", "off");
            mainWindow.AktivitaButtonu();
        }

        private void svetlaLustrButton_Click(object sender, RoutedEventArgs e)
        {
            spravceCidel.SvetlaINAuto("kuchyn", "lustr");
            mainWindow.AktivitaButtonu();
        }

        private void zpetButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SvetlaPageIN1();
        }
    }
}
