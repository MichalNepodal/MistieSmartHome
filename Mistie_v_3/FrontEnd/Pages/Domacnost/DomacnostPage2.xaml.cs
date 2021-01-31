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
    /// Interakční logika pro DomacnostPage2.xaml
    /// </summary>
    public partial class DomacnostPage2 : Page
    {
        MainWindow mainWindow;

        public DomacnostPage2(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.DomacnostPage();
            mainWindow.AktivitaButtonu();
        }

        private void hudbaButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
