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
    /// Interakční logika pro NastaveniPage.xaml
    /// </summary>
    public partial class NastaveniPage : Page
    {
        MainWindow mainWindow;

        public NastaveniPage(Mistie mistie, MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }
        private void mistiePageButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.MistiePage1();
        }

        private void zvukNastaveni_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Close();
        }
    }
}
