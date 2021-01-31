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
    /// Interakční logika pro ZabezpeceniPage.xaml
    /// 
    /// </summary>
    /// 

    
    public partial class ZabezpeceniPage : Page
    {
        // PAGES
        MainWindow mainWindow;
        // CLASS
        SpravceZabezpeceni spravceZabezpeceni;

        public ZabezpeceniPage(MainWindow mainWindow, SpravceZabezpeceni spravceZabezpeceni)
        {
            this.mainWindow = mainWindow;
            this.spravceZabezpeceni = spravceZabezpeceni;
            InitializeComponent();
        }

        private void aktivovatZabezpeceniButton_Click(object sender, RoutedEventArgs e)
        {            
            spravceZabezpeceni.AktivovatZabezpeceni();
            mainWindow.AktivitaButtonu();
        }
        private void deaktivovatZabezpeceniButton_Click(object sender, RoutedEventArgs e)
        {
            spravceZabezpeceni.DeaktivovatZabezpeceni();
            mainWindow.AktivitaButtonu();
        }
        private void HomeZabezpeceniButton_Click(object sender, RoutedEventArgs e)
        {
            spravceZabezpeceni.HomeZabezpeceniAktivovat();
            mainWindow.AktivitaButtonu();
        }
        private void poplachButton_Click(object sender, RoutedEventArgs e)
        {
            spravceZabezpeceni.PoplachTisen();
        }
    }
}
