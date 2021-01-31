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

namespace Mistie_v_3.FrontEnd.Pages.Zabezpeceni
{
    /// <summary>
    /// Interaction logic for HesloPage1.xaml
    /// </summary>
    public partial class HesloPage1 : Page
    {

        // CLASS
        MainWindow mainWindow;
        SpravceZabezpeceni spravceZabezpeceni;
        

        
        public HesloPage1(MainWindow mainWindow, SpravceZabezpeceni spravceZabezpeceni)
        {
            this.mainWindow = mainWindow;
            this.spravceZabezpeceni = spravceZabezpeceni;
            OdesliObjektSpravZabezpeceni();
            InitializeComponent();
        }

        private void cislo1Button_Click(object sender, RoutedEventArgs e)
        {            
            displayTextBlock.Text += "*";
            spravceZabezpeceni.KontrolaHesla("1");
        }
        private void cislo2Button_Click(object sender, RoutedEventArgs e)
        {
            displayTextBlock.Text += "*";
            spravceZabezpeceni.KontrolaHesla("2");
        }
        private void cislo3Button_Click(object sender, RoutedEventArgs e)
        {
            displayTextBlock.Text += "*";
            spravceZabezpeceni.KontrolaHesla("3");
        }
        private void cislo4Button_Click(object sender, RoutedEventArgs e)
        {
            displayTextBlock.Text += "*";
            spravceZabezpeceni.KontrolaHesla("4");
        }
        private void cislo5Button_Click(object sender, RoutedEventArgs e)
        {
            displayTextBlock.Text += "*";
            spravceZabezpeceni.KontrolaHesla("5");
        }
        private void cislo6Button_Click(object sender, RoutedEventArgs e)
        {
            displayTextBlock.Text += "*";
            spravceZabezpeceni.KontrolaHesla("6");
        }
        private void cislo7Button_Click(object sender, RoutedEventArgs e)
        {
            displayTextBlock.Text += "*";
            spravceZabezpeceni.KontrolaHesla("7");
        }
        private void cislo8Button_Click(object sender, RoutedEventArgs e)
        {
            displayTextBlock.Text += "*";
            spravceZabezpeceni.KontrolaHesla("8");
        }
        private void cislo9Button_Click(object sender, RoutedEventArgs e)
        {
            displayTextBlock.Text += "*";
            spravceZabezpeceni.KontrolaHesla("9");
        }
        private void cislo0Button_Click(object sender, RoutedEventArgs e)
        {
            displayTextBlock.Text += "*";
            spravceZabezpeceni.KontrolaHesla("0");
        }
        private void vynulovatHesloButton_Click(object sender, RoutedEventArgs e)
        {
            spravceZabezpeceni.VynulovatHeslo();
        }

        // METODA PŘI VYTVTOŘENÍ 
        // METODA PŘI VYTVTOŘENÍ 
        private void OdesliObjektSpravZabezpeceni()
        {
            spravceZabezpeceni.NactiHesloPage1(this);
        }
    }
}
