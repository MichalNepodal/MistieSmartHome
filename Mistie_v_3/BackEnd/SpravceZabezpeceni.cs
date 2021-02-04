using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System.Threading;
using Mistie_v_3.FrontEnd.Pages.Zabezpeceni;

namespace Mistie_v_3.BackEnd
{
    public class SpravceZabezpeceni
    {
       
        MainWindow mainWindow;
        //List<string> seznamSignalu;
        SpravceCidel spravceCidel;
        HesloPage1 hesloPage1;
        SpravceHudby spravceHudby;
        BackGroundProcesy backGroundProcesy;

        // Vlakno
        Thread AktivZabezpecenivlakno;

        private string Heslo { get;}

        private bool ZabezpeceniAktivovano { get; set; }
        private bool SleepRezimAktivovano { get; set; }
        private bool OdpocetAktivace { get; set; }
        private bool NaruseniObjektuAktivovano { get; set; }    
        private bool PoplachAktivovan { get; set; }

        // HESLO
        string zadaneHeslo = "";

        // Arduino
        string zprava = "";

        //string zpravaSpravciCidel = "";

        public SpravceZabezpeceni(MainWindow mainWindow, BackGroundProcesy backGroundProcesy)
        {
            this.mainWindow = mainWindow;
            this.backGroundProcesy = backGroundProcesy;
            //seznamSignalu = new List<string>();
            NaruseniObjektuAktivovano = false;
            ZabezpeceniAktivovano = false;
            SleepRezimAktivovano = false;
            PoplachAktivovan = false;
            OdpocetAktivace = false;
            Heslo = "1234"; // testovací
        }


        // ARDUINO PŘÍJEM ZPRÁVY
        // ARDUINO PŘÍJEM ZPRÁVY
        public void KontrolaZabezpeceni(string arduinoText)
        {
            
            if (arduinoText.Contains("p"))
            {
                MessageBox.Show("v tecxtu je P");
                zprava = arduinoText.Remove(0, 1);
                if (zprava == "magnet" || zprava == "chodba")
                    ProveritZaznam();
            }
        }
        private void ProveritZaznam()
        {
            if (!NaruseniObjektuAktivovano)
            {
                if(SleepRezimAktivovano && zprava == "magnet")
                {
                    NaruseniObjektu("on");
                    NaruseniObjektuAktivovano = true;
                }
                if (ZabezpeceniAktivovano)
                {
                    if (zprava == "magnet" || zprava == "chodba")
                    {
                        NaruseniObjektu("on");
                        NaruseniObjektuAktivovano = true;
                    }
                }
            }
        }

        // ZABEZPEČENÍ 
        // ZABEZPEČENÍ 

        // --- Kontrola Hesla
        public void KontrolaHesla(string cislo)
        {
            zadaneHeslo += cislo;
            if(zadaneHeslo.Trim().Length == 4)
            {
                if(zadaneHeslo == Heslo)
                {
                    mainWindow.HesloPageAktivni("off");
                    NaruseniObjektuAktivovano = false;
                    ZabezpeceniAktivovano = false;
                    SleepRezimAktivovano = false;
                    PoplachAktivovan = false;
                    OdpocetAktivace = false;
                    backGroundProcesy.ZmenaStavuPoplachu("off");
                    VynulovatHeslo();
                    //spravceHudby.ZvukSpravnehoHesla();
                    StavZabezpeceni("", "off");
                    spravceCidel.ZmenaStavuZabezpeceni("off");
                }
                else
                {
                    VynulovatHeslo();
                    //spravceHudby.ZvukNespravnehoHesla();
                }
            }
            mainWindow.AktivitaButtonu();
        }
        public void VynulovatHeslo()
        {
            zadaneHeslo = "";
            hesloPage1.displayTextBlock.Text = "";
        }

        // ----- NARUŠENÍ, POPLACH ----
        private void NaruseniObjektu(string akce)
        {
            MessageBox.Show("narušení objektu ON");
            if (akce == "on")
            {
                NaruseniObjektuAktivovano = true;
                spravceCidel.ZmenaStavuNaruseni("on");                
                mainWindow.HesloPageAktivni("on");
                spravceCidel.SvetlaIN("chodba", "lustr", "on");
                Thread.Sleep(22);                
                Thread vlaknoOdpoctuPoplachu = new Thread(SpustitOdpocetPoplachu);
                vlaknoOdpoctuPoplachu.Start();
                backGroundProcesy.ZmenaStavuPoplachu("on");
            }
            else if (akce == "off")
            {
                NaruseniObjektuAktivovano = false;
                spravceCidel.ZmenaStavuNaruseni("off");
                mainWindow.HesloPageAktivni("off");
                MessageBox.Show("Poplach vypnut");
            }
        }
        private void SpustitOdpocetPoplachu()
        {
            Thread.Sleep(5000);
            spravceCidel.SvetlaIN("kuchyn", "lustr", "on");
            Thread.Sleep(22);
            spravceCidel.SvetlaIN("loznice", "lustr", "on");
            Thread.Sleep(22);
            spravceCidel.SvetlaIN("chodba", "lustr", "on");
            Thread.Sleep(5000);

            if (!NaruseniObjektuAktivovano)
            {
                MessageBox.Show("Heslo zadáno do systému. Poplach DEAKTIVOVÁN");
            }
            else
            {
                MessageBox.Show("Do 40 vteřin nezadáno heslo. Spouštím POPLACH!!");
                PoplachAktivovan = true;
                SpustitPoplach();
            }
        }
        private void SpustitPoplach()
        {
            spravceHudby.ZvukAlarm1();
            MessageBox.Show("Odesílání SMS a volání");
        }
    

        // METODY OD JINÝCH CLASS
        // METODY OD JINÝCH CLASS
        public void HomeZabezpeceniAktivovat()
        {
            if (!SleepRezimAktivovano && !ZabezpeceniAktivovano && !OdpocetAktivace)
            {
                SleepRezimAktivovano = true;
                mainWindow.HomeZabezpeceniOpacity(1);
                spravceCidel.ZmenaStavuZabezpeceni("on");    
            }
        }
        public void SleepAktivovat()
        {
            if (!ZabezpeceniAktivovano && !SleepRezimAktivovano && !OdpocetAktivace)
            {
                mainWindow.HomeZabezpeceniOpacity(1);
                OdpocetAktivace = true;
                spravceCidel.SleepVlaknoAktivovat("on");
                spravceCidel.ZmenaStavuZabezpeceni("on");
            }
        }
        public void OdchodZDomuAktivovat()
        {
            if(!ZabezpeceniAktivovano && !SleepRezimAktivovano && !OdpocetAktivace)
            {
                mainWindow.ZamekOpacity(1);
                OdpocetAktivace = true;
                spravceCidel.OdchodZDomuAktivovat("on");               
            }
        }

        public void AktivovatZabezpeceni()
        {
            if (!ZabezpeceniAktivovano && !SleepRezimAktivovano && !OdpocetAktivace)
            {
                OdpocetAktivace = true;
                AktivZabezpecenivlakno = new Thread(AktivovatZabezpeceniVlakno);
                AktivZabezpecenivlakno.Start();                
            }                
        }
        public void AktivovatZabezpeceniVlakno()
        {
            //MessageBox.Show("Zabezpeceni za 5 sec.");
            mainWindow.ZamekOpacity(1);
            Thread.Sleep(5000);
            OdpocetAktivace = false;
            StavZabezpeceni("plne", "on");
            spravceCidel.ZmenaStavuZabezpeceni("on");
        }
        public void StavZabezpeceni(string typ, string stav)
        {
            if(stav == "off")
            {
                ZabezpeceniAktivovano = false;
                SleepRezimAktivovano = false;
                mainWindow.ZamekOpacity(0.1);
                mainWindow.HomeZabezpeceniOpacity(0.1);
                backGroundProcesy.ZmenaStavuPoplachu("off");
                spravceCidel.ZmenaStavuZabezpeceni("off");
            }
            else if(stav == "on")
            {
                if (typ == "plne")
                {
                    ZabezpeceniAktivovano = true;
                    MessageBox.Show("Zabzepecení aktivováno");

                }
                if (typ == "sleep")
                {
                    OdpocetAktivace = false;
                    SleepRezimAktivovano = true;
                    mainWindow.ZamekOpacity(1);
                }
            }
        }
        public void DeaktivovatZabezpeceni()
        {
            if (ZabezpeceniAktivovano || SleepRezimAktivovano)
                mainWindow.HesloPageAktivni("on");
            else if (AktivZabezpecenivlakno != null && AktivZabezpecenivlakno.IsAlive)
            {
                AktivZabezpecenivlakno.Abort(); // zničí vlákno odpočítávání zabezpečení
                mainWindow.ZamekOpacity(0.1);
                backGroundProcesy.ZmenaStavuPoplachu("off");
                spravceCidel.ZmenaStavuZabezpeceni("off");
            }
            
            spravceCidel.SleepVlaknoAktivovat("off");
            OdpocetAktivace = false;            
        }
        public void PoplachTisen()
        {
            SpustitPoplach();
        }

        // METODA PO BUILDU
        public void NactiSpravceCidel(SpravceCidel spravceCidel)
        {
            this.spravceCidel = spravceCidel;
        }

        public void NactiHesloPage1(HesloPage1 hesloPage1)
        {
            this.hesloPage1 = hesloPage1;
        }
        public void NactiSpravceHudby(SpravceHudby spravceHudby)
        {
            this.spravceHudby = spravceHudby;
        }
    }
}
