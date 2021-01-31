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
    /// Interakční logika pro HudbaPage1.xaml
    /// </summary>
    public partial class HudbaPage1 : Page
    {
     
        MainWindow mainWindow;
        SpravceHudby spravceHudby;

        public HudbaPage1(SpravceHudby spravceHudby, MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.spravceHudby = spravceHudby;
            InitializeComponent();
        }

        private void zpetButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.HomePage1();
        }
        private void spustitHudbuButton_Click(object sender, RoutedEventArgs e)
        {
            spravceHudby.PlayMusic();
            mainWindow.AktivitaButtonu();
        }
        private void vypnoutHudbuButton_Click(object sender, RoutedEventArgs e)
        {
            spravceHudby.StopMusic();
            mainWindow.AktivitaButtonu();
        }
    }
}
