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
    /// Interakční logika pro MistiePage1.xaml
    /// </summary>
    public partial class MistiePage1 : Page
    {
        MainWindow mainWindow;
        Mistie mistie;

        public MistiePage1(MainWindow mainWindow, Mistie mistie)
        {
            this.mainWindow = mainWindow;
            this.mistie = mistie;
            InitializeComponent();
        }

        private void aktivovatHlasoveOvladaniButton_Click(object sender, RoutedEventArgs e)
        {
            mistie.ZapnoutOvladaniHlasem("on");
            mainWindow.AktivitaButtonu();
        }

        private void deaktivovatHlasoveOvladaniButton_Click(object sender, RoutedEventArgs e)
        {
            mistie.ZapnoutOvladaniHlasem("off");
            mainWindow.AktivitaButtonu();
        }
        private void zpetButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.NastaveniPage();
        }
    }
}
