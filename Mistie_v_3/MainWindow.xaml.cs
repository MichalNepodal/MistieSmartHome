using Mistie_v_3.BackEnd;
using Mistie_v_3.FrontEnd.Pages;
using Mistie_v_3.FrontEnd.Pages.Home;
using Mistie_v_3.FrontEnd.Pages.Web;
using Mistie_v_3.FrontEnd.Pages.Zabezpeceni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using static Mistie_v_3.BackEnd.SpravceZabezpeceni;

//using System.Timers; - to je k opakované činnosti (Timer v jiném vlákně).

namespace Mistie_v_3
{

    //public delegate void AktivitaButtonHandler();

    public partial class MainWindow : Window
    {
        //CLASS
        BackGroundProcesy backGroundProcesy;
        Mistie mistie;
        SpravceCidel spravceCidel;
        SpravceHudby spravceHudby;
        SpravceZabezpeceni spravceZabezpeceni;
        //ArduinoCtecka arduinoCtecka;
        // PAGES
        HomePage1 homePage1;
        DomacnostPage domacnostPage;
        DomacnostPage2 domacnostPage2;
        DomacnostCollectionPage1 domacnostCollectionPage1;
        DomacnostCollectionPage2 domacnostCollectionPage2;

        SvetlaPage1 svetlaPage1;
        SvetlaPageIN1 svetlaPageIN1;
        SvetlaCollectionPage1 svetlaCollectionPage1;
        SvetlaPracovnaPage1 svetlaPracovnaPage1;
        SvetlaChodbaPage1 svetlaChodbaPage1;
        SvetlaWCPage1 svetlaWCPage1;
        SvetlaKoupelnaPage1 svetlaKoupelnaPage1;
        SvetlaKuchynPage1 svetlaKuchynPage1;
        SvetlaObyvakPage1 svetlaObyvakPage1;
        SvetlaLoznicePage1 svetlaLoznicePage1;

        ZabezpeceniPage zabezpeceniPage;
        ZabezpeceniCollectionPage1 zabezpeceniCollectionPage1;
        HesloPage1 hesloPage1;

        NastaveniPage nastaveniPage;
        HudbaPage1 hudbaPage1;
        InformaceTvurcePage1 informaceTvurcePage1;
        //WebPage1 webPage1;
                
        MistiePage1 mistiePage1;

        public bool PocitatAktivitu = false;
        public int aktivitaCislo = 0;

        

        public MainWindow()
        {
            this.backGroundProcesy = new BackGroundProcesy(this);
            spravceZabezpeceni = new SpravceZabezpeceni(this, backGroundProcesy);
            svetlaPage1 = new SvetlaPage1(this, spravceCidel);
            svetlaPageIN1 = new SvetlaPageIN1(this, spravceCidel);
            svetlaCollectionPage1 = new SvetlaCollectionPage1(this, spravceCidel);
            svetlaPracovnaPage1 = new SvetlaPracovnaPage1(this, spravceCidel);
            svetlaChodbaPage1 = new SvetlaChodbaPage1(this, spravceCidel);
            svetlaWCPage1 = new SvetlaWCPage1(this, spravceCidel);
            svetlaKoupelnaPage1 = new SvetlaKoupelnaPage1(this, spravceCidel);
            svetlaKuchynPage1 = new SvetlaKuchynPage1(this, spravceCidel);
            svetlaObyvakPage1 = new SvetlaObyvakPage1(this, spravceCidel);
            svetlaLoznicePage1 = new SvetlaLoznicePage1(this, spravceCidel);



            spravceCidel = new SpravceCidel(this, spravceZabezpeceni, backGroundProcesy);
            spravceHudby = new SpravceHudby(spravceZabezpeceni);
            mistie = new Mistie(this, spravceCidel, spravceHudby);            
            domacnostPage = new DomacnostPage(this, spravceCidel, spravceZabezpeceni);
            domacnostPage2 = new DomacnostPage2(this);
            domacnostCollectionPage1 = new DomacnostCollectionPage1(this, spravceCidel);
            domacnostCollectionPage2 = new DomacnostCollectionPage2(this);
            zabezpeceniPage = new ZabezpeceniPage(this, spravceZabezpeceni);
            //zabezpeceniPage.AktivitaButtonEvent += new AktivitaButtonHandler (OdpocitavatAktivituTlacitka);
            zabezpeceniCollectionPage1 = new ZabezpeceniCollectionPage1(this);
            nastaveniPage = new NastaveniPage(mistie, this);
            informaceTvurcePage1 = new InformaceTvurcePage1();
            hesloPage1 = new HesloPage1(this, spravceZabezpeceni);
            homePage1 = new HomePage1(spravceCidel, backGroundProcesy, this, spravceZabezpeceni);
            mistiePage1 = new MistiePage1(this, mistie);
            hudbaPage1 = new HudbaPage1(spravceHudby, this);
            //webPage1 = new WebPage1(this);

            InitializeComponent();
            //mistieSayTextBlock.Text = ".....";
            mainWindowFrame.NavigationService.Navigate(homePage1);
        }




        public void AktivitaButtonu()
        {
            backGroundProcesy.AktivitaButtonu();
        }

        // BUTTONS METODY    BUTTONS METODY    BUTTONS METODY
        // BUTTONS METODY    BUTTONS METODY    BUTTONS METODY
        // BUTTONS METODY    BUTTONS METODY    BUTTONS METODY

        private void informaceButton_Click(object sender, RoutedEventArgs e)
        {
            InformaceTvurcePage1();
        }
        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage1();
            AktivitaButtonu();
        }

        private void domacnostPageButton_Click(object sender, RoutedEventArgs e)
        {
            DomacnostPage();
            AktivitaButtonu();
        }

        private void zabezpeceniPageButton_Click(object sender, RoutedEventArgs e)
        {
            ZabezpeceniPage();
            AktivitaButtonu();
        }

        private void nastaveniButton_Click(object sender, RoutedEventArgs e)
        {
            NastaveniPage();
            AktivitaButtonu();
        }





        // CHANGE FRAME PAGE   CHANGE FRAME PAGE
        // CHANGE FRAME PAGE   CHANGE FRAME PAGE
        // CHANGE FRAME PAGE   CHANGE FRAME PAGE

        public void HomePage1()
        {
            mainWindowFrame.NavigationService.Navigate(homePage1);
            AktivitaButtonu();
        }
        public void DomacnostPage()
        {
            mainWindowFrame.NavigationService.Navigate(domacnostPage);
            AktivitaButtonu();
        }
        public void DomacnostPage2()
        {
            mainWindowFrame.NavigationService.Navigate(domacnostPage2);
            AktivitaButtonu();
        }
        public void DomacnostCollectionPage1()
        {
            mainWindowFrame.NavigationService.Navigate(domacnostCollectionPage1);
            AktivitaButtonu();
        }
        public void DomacnostCollectionPage2()
        {
            mainWindowFrame.NavigationService.Navigate(domacnostCollectionPage2);
            AktivitaButtonu();
        }
        public void SvetlaPage1()
        {
            mainWindowFrame.NavigationService.Navigate(svetlaPage1);
            AktivitaButtonu();
        }
        public void SvetlaPageIN1()
        {
            mainWindowFrame.NavigationService.Navigate(svetlaPageIN1);
            AktivitaButtonu();
        }
        public void SvetlaChodbaPage1()
        {
            mainWindowFrame.NavigationService.Navigate(svetlaChodbaPage1);
            AktivitaButtonu();
        }
        public void SvetlaCollectionPage1()
        {
            mainWindowFrame.NavigationService.Navigate(svetlaCollectionPage1);
            AktivitaButtonu();
        }
        public void SvetlaKoupelnaPage1()
        {
            mainWindowFrame.NavigationService.Navigate(svetlaKoupelnaPage1);
            AktivitaButtonu();
        }
        public void SvetlaKuchynPage1()
        {
            mainWindowFrame.NavigationService.Navigate(svetlaKuchynPage1);
            AktivitaButtonu();
        }
        public void SvetlaLoznicePage1()
        {
            mainWindowFrame.NavigationService.Navigate(svetlaLoznicePage1);
            AktivitaButtonu();
        }
        public void SvetlaObyvakPage1()
        {
            mainWindowFrame.NavigationService.Navigate(svetlaObyvakPage1);
            AktivitaButtonu();
        }
        public void SvetlaPracovnaPage1()
        {
            mainWindowFrame.NavigationService.Navigate(svetlaPracovnaPage1);
            AktivitaButtonu();
        }
        public void SvetlaWCPage1()
        {
            mainWindowFrame.NavigationService.Navigate(svetlaWCPage1);
            AktivitaButtonu();
        }
        public void ZabezpeceniPage()
        {
            mainWindowFrame.NavigationService.Navigate(zabezpeceniPage);
            AktivitaButtonu();
        }
        public void ZabezpeceniCollectionPage()
        {
            mainWindowFrame.NavigationService.Navigate(zabezpeceniPage);
            AktivitaButtonu();
        }
        public void NastaveniPage()
        {
            mainWindowFrame.NavigationService.Navigate(nastaveniPage);
            AktivitaButtonu();
        }

        public void InformaceTvurcePage1()
        {
            mainWindowFrame.NavigationService.Navigate(informaceTvurcePage1);
            AktivitaButtonu();
        }
        public void MistiePage1()
        {
            mainWindowFrame.NavigationService.Navigate(mistiePage1);
            AktivitaButtonu();
        }
        public void HudbaPage1()
        {
            mainWindowFrame.NavigationService.Navigate(hudbaPage1);
            AktivitaButtonu();
        }
        public void HomePage1Vlakno() // aktivuje ji vlákno, kter= odpočítává aktivitu buttonu, po nějaké době neaktivity.
        {
            this.Dispatcher.Invoke(() => { mainWindowFrame.NavigationService.Navigate(homePage1); });
        }
        //public void WebPage1()
        //{
        //    mainWindowFrame.NavigationService.Navigate(webPage1);
        //}



        // METODY PŘÍCHOZÍ    METODY PŘÍCHOZÍ    
        // METODY PŘÍCHOZÍ    METODY PŘÍCHOZÍ    

        public void HesloPageAktivni(string stav)
        {
            if (stav == "on")
            {
                spravceZabezpeceni.VynulovatHeslo();
                mainWindowFrame.NavigationService.Navigate(hesloPage1);
            }
            else
                HomePage1();
        }
        public void ZamekOpacity(double hodnota) // Dispatcher.Invoke - vedlejší vlákno předá úkol hlavnímu vláknu, protožejen hlavní může upravovat vlastnosti WPF (protože havní vlákno tyto vlastnosti vytvořilo). Jen tvůrce je může upravovat. 
        {
            if(hodnota == 1)
                this.Dispatcher.Invoke(() => { zamekONOFFBorder.Opacity = 1; });
            else
                this.Dispatcher.Invoke(() => { zamekONOFFBorder.Opacity = 0.1; });
        }
        public void MicrophoneOpacity(double hodnota) 
        {
            if (hodnota == 1)
                this.Dispatcher.Invoke(() => { MicrophoneOnOffBorder.Opacity = 1; });
            else
                this.Dispatcher.Invoke(() => { MicrophoneOnOffBorder.Opacity = 0.1; });
        }
        public void HomeZabezpeceniOpacity(double hodnota)
        {
            if (hodnota == 1)
                this.Dispatcher.Invoke(() => { HomeZabezpeceniBorder.Opacity = 1; });
            else
                this.Dispatcher.Invoke(() => { HomeZabezpeceniBorder.Opacity = 0.1; });
        }
    }
}