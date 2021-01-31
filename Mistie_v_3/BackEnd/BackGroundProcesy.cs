﻿using Mistie_v_3.FrontEnd.Pages.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Mistie_v_3.BackEnd
{
    public class BackGroundProcesy
    {

        // CLASS


        // PAGES
        MainWindow mainWindow;
        HomePage1 homePage1;
        DateTime datumCas = new DateTime();

        // Vlakno
        Thread VlaknoAktivitaButtonu;

        //private bool aktivitaButtonu;
        private int aktivitaButtonuCislo = 0;

        private bool PoplachAktivovan { get; set; }


        public BackGroundProcesy(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            PoplachAktivovan = false;            
        }

        public void ZmenaStavuPoplachu(string stav)
        {
            if (stav == "on")
                PoplachAktivovan = true;
            else
                PoplachAktivovan = false;
        }


        public void AktivitaButtonu()
        {
            if(VlaknoAktivitaButtonu == null || !VlaknoAktivitaButtonu.IsAlive)
            {
                aktivitaButtonuCislo = 30;
                VlaknoAktivitaButtonu = new Thread(OdpocitavaniAktivitiyButtonu);
                VlaknoAktivitaButtonu.IsBackground = true;
                VlaknoAktivitaButtonu.Start();
            }
            else
            {
                aktivitaButtonuCislo = 30;
            }                
        }
        private void OdpocitavaniAktivitiyButtonu()
        {
            while (aktivitaButtonuCislo > 0)
            {
                Thread.Sleep(2000);
                aktivitaButtonuCislo -= 10;
            }
            if(!PoplachAktivovan)
                mainWindow.HomePage1Vlakno();
        }



        






        // TIME    TIME    TIME
        // TIME    TIME    TIME
        // TIME    TIME    TIME

        private void AutomatickaAktualizace(object sender, EventArgs e)
        {
            mainWindow.casTextBlock.Text = VratAktualniCas();
            //homePage1.AktualizovatTeplotu();
            
        }
        public string VratAktualniCas()
        {
            datumCas = DateTime.Now;
            string minuty = datumCas.Minute.ToString();
            if (minuty.Length < 2)
                minuty = "0" + datumCas.Minute.ToString();

            string aktualniCas = datumCas.Day + "." + datumCas.Month + "." + datumCas.Year + "   " + datumCas.Hour + ":" + minuty;
            return aktualniCas;
        }



        // METODY PŘI BUILDU
        // METODY PŘI BUILDU
        public void AktivaceAktualizaceCasu()
        {
            try
            {
                DispatcherTimer timer = new DispatcherTimer();
                timer.Tick += new EventHandler(AutomatickaAktualizace);
                timer.Interval = new TimeSpan(0, 0, 10); // každých 10 sekund spustí metodu v předchozí řádce (timer.Tick)
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vyjímka:\nNepodařilo se spustit automatickou aktualizaci času");
            }
        }
        public void NactiHomePage1(HomePage1 homePage1)
        {
            this.homePage1 = homePage1;
        }
    }
}
