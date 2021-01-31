using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Mistie_v_3.BackEnd
{

    //   ----- SVETLA   SVETLA    SVETLA -----

    //  0 - SvetloLustrPracovna - OFF
    //  1 - SvetloLustrPracovna - ON
    //  2 - SvetloLustrCHodba - OFF
    //  3 - SvetloLustrCHodba - ON
    //  4 - SvetloLustrWC - OFF
    //  5 - SvetloLustrWC - ON
    //  6 - SvetloLustrKoupelna - OFF
    //  7 - SvetloLustrKoupelna - ON
    //  8 - SvetloLustrKuchyn - OFF
    //  9 - SvetloLustrKuchyn - ON
    //  a - SvetloLustrObyvak - OFF
    //  b - SvetloLustrObyvak - ON
    //  c - SvetloLustrLoznice - OFF
    //  d - SvetloLustrLoznice - ON

    // ------------------------

    //  e - SvetloLampaLoznice - OFF
    //  f - SvetloLampaLoznice - ON
    //  g - SvetloLampaObyvak - OFF
    //  h - SvetloLampaObyvak - ON   
    //  i - SvetloLedKuchyn - OFF
    //  j - SvetloLedKuchyn - ON    
    //  k - SvetloDekoraceLoznice - OFF
    //  l - SvetloDekoraceLoznice - ON
    //  m - SvetloDekoraceObyvak - OFF
    //  n - SvetloDekoraceObyvak - ON    
    //  o - SvetloDekoracePracovna - OFF
    //  p - SvetloDekoracePracovna - ON

    //  q - LustrPracovna - ON/OFF
    //  r - LustrChodba - ON/OFF
    //  s - LustrWc - ON/OFF
    //  t - LustrKoupelna - ON/OFF
    //  u - LustrKuchyn - ON/OFF
    //  v - LustrObyvak - ON/OFF
    //  w - LustrLoznice - ON/OFF

    //  x - LedKuchyn - ON/OFF
    //  y - LampaObyvak - ON/OFF
    //  z - LampaLoznice - ON/OFF


    // A - DekoracePracovna - ON/OFF
    // B - DekoraceObyvak - ON/OFF  
    // C - DekoraceLoznice - ON/OFF  
    // D - 
 

    public class SpravceCidel
    {
        // CLASS
        MainWindow mainWindow;
        SpravceZabezpeceni spravceZabezpeceni;
        SerialPort serialPort = new SerialPort();  // připojení k Arduino desce.

        //Vlakno
        Thread vlaknoSleep;
        Thread odchodZDomuVlakno;

        // ATRIBUTS
        private string ArduinoText = "";
        private int ArduinoTeplota = 0;
        private int ArduinoVlhkost = 0;


        // BOOLS
        private bool ZabezpeceniAktivovano { get; set; }
        private bool SleepRezimAktivovan { get; set; }
        private bool NaruseniObjektuAktivovano { get; set; }
        private bool PoplachAktivovan { get; set; }

        public SpravceCidel(MainWindow mainWindow, SpravceZabezpeceni spravceZabezpeceni)
        {
            this.mainWindow = mainWindow;
            this.spravceZabezpeceni = spravceZabezpeceni;
            ZabezpeceniAktivovano = false;
            SleepRezimAktivovan = false;
            NaruseniObjektuAktivovano = false;
            PoplachAktivovan = false;
            ZabezpeceniObjektOdesli();
            PripojitCidla();
            Thread.Sleep(400);
        }


        // -------------------------------- ZABEZPEČENÍ     ZABEZPEČENÍ ---------------------------------------------
        // -------------------------------- ZABEZPEČENÍ     ZABEZPEČENÍ ---------------------------------------------

        public void ZmenaStavuNaruseni(string stav)
        {
            if (stav == "on")
                NaruseniObjektuAktivovano = true;
            else
                NaruseniObjektuAktivovano = false;

        }

        public void ZmenaStavuZabezpeceni(string typ, string stav) // stav on / off
        {
            MessageBox.Show("ZABEZPEČENÍ AKTIVOVÁNO");
            if (typ == "plne")
            {
                if (stav == "on")
                {
                    ZabezpeceniAktivovano = true;
                    spravceZabezpeceni.StavZabezpeceni("plne", "on");
                }
                else if (stav == "off")
                {
                    ZabezpeceniAktivovano = false;
                    spravceZabezpeceni.StavZabezpeceni("plne", "off");
                }
            }
            if (typ == "sleep")
            {
                if (stav == "on")
                {
                    SleepRezimAktivovan = true;
                    spravceZabezpeceni.StavZabezpeceni("sleep", "on");
                }
                else if (stav == "off")
                {
                    SleepRezimAktivovan = false;
                    spravceZabezpeceni.StavZabezpeceni("sleep", "off");
                }
            }
        }


        private void OdchodZDomuVlakno()
        {
            SvetlaIN("chodba", "", "on");
            Thread.Sleep(22);
            SvetlaIN("pracovna", "", "off");
            Thread.Sleep(22);
            SvetlaIN("kuchyn", "", "off");
            Thread.Sleep(22);
            SvetlaIN("WC", "", "off");
            Thread.Sleep(22);
            SvetlaIN("koupelna", "", "off");
            Thread.Sleep(22);
            SvetlaIN("loznice", "", "off");
            Thread.Sleep(22);
            SvetlaIN("obyvak", "", "off");
            // Promluví slovo Aktivuji abezpečení
            Thread.Sleep(10000);
            SvetlaIN("chodba", "", "off");
            spravceZabezpeceni.AktivovatZabezpeceniVlakno();
        }
        


        //------------------------------------- BUTTONS  metody    BUTTONS metody    -------------------------------------------
        //------------------------------------- BUTTONS  metody    BUTTONS metody    -------------------------------------------
        public void OdchodZDomuAktivovat(string stav)
        {
            if(stav == "on")
            {
                odchodZDomuVlakno = new Thread(OdchodZDomuVlakno);
                odchodZDomuVlakno.Start();
            }
            else if(stav == "off")
            {
                if (odchodZDomuVlakno.IsAlive)
                    odchodZDomuVlakno.Abort();
            }
            
            
        }
        public void PrichodDomuAktivovat()
        {           
            Thread.Sleep(22);
            SvetlaIN("kuchyn", "", "on");
            Thread.Sleep(22);
            SvetlaIN("chodba", "", "on");            
        }
        public void SleepVlaknoAktivovat(string stav)
        {            
            if(stav == "on")
            {
                vlaknoSleep = new Thread(SleepVlakno);
                vlaknoSleep.Start();
            }
            else if(stav == "off")
            {
                if(vlaknoSleep != null && vlaknoSleep.IsAlive)
                    vlaknoSleep.Abort();
            }            
        }
        
        public void CollectionPracovnaPrace()
        {
            Thread.Sleep(22);
            SvetlaIN("pracovna", "", "on");
            Thread.Sleep(22);
            SvetlaIN("kuchyn", "", "off");
            Thread.Sleep(22);
            SvetlaIN("WC", "", "off");
            Thread.Sleep(22);
            SvetlaIN("chodba", "", "off");
            Thread.Sleep(22);
            SvetlaIN("koupelna", "", "off");
            Thread.Sleep(22);
            SvetlaIN("loznice", "", "off");
            Thread.Sleep(22);
            SvetlaIN("obyvak", "", "off");
        }
        public void CollectionRelaxTelevize()
        {
            Thread.Sleep(22);
            SvetlaIN("pracovna", "", "off");
            Thread.Sleep(22);
            SvetlaIN("kuchyn", "", "off");
            Thread.Sleep(22);
            SvetlaIN("WC", "", "off");
            Thread.Sleep(22);
            SvetlaIN("chodba", "", "off");
            Thread.Sleep(22);
            SvetlaIN("koupelna", "", "off");
            Thread.Sleep(22);
            SvetlaIN("loznice", "", "off");
            Thread.Sleep(22);
            SvetlaIN("obyvak", "", "on");
        }

        // --- PŘICHOTÍ METODY     PŘICHOTÍ METODY --- ZABEZPEČENÍ




        //------------------------------------------  VLASTNÍ METODY     VLASTNÍ METODY   ------------------------------------------  
        //------------------------------------------  VLASTNÍ METODY     VLASTNÍ METODY   ------------------------------------------  


        // SVĚTLO ----------  SVĚTLO
        // SVĚTLO ----------  SVĚTLO

        
        public void SvetlaINAuto(string mistnost, string druhSvetla) // zašle Arduinu zprávu jako vypínač a to automaticky vypne, nebo zapne světlo podle boolu Arduina.
        {
            if(mistnost == "pracovna")
            {
                switch (druhSvetla)
                {
                    case "lustr":
                        serialPort.Write("q");
                        Thread.Sleep(22);
                        break;
                }
            }
            if (mistnost == "chodba")
            {
                serialPort.Write("r");
                Thread.Sleep(22);
                return;
            }                
            if (mistnost == "wc")
            {
                serialPort.Write("s");
                Thread.Sleep(22);
                return;
            }
            if (mistnost == "koupelna")
            {
                serialPort.Write("t");
                MessageBox.Show("koupelna slyšela, odešlo do arduina");
                Thread.Sleep(22);
                return;
            }
            if (mistnost == "kuchyn")
            {
                serialPort.Write("u");
                Thread.Sleep(22);
                return;
            }
            if (mistnost == "obyvak")
            {
                switch (druhSvetla)
                {
                    case "lustr":
                        serialPort.Write("v");
                        Thread.Sleep(22);
                        break;
                }
            }
            if (mistnost == "loznice")
            {
                switch (druhSvetla)
                {
                    case "lustr":
                        serialPort.Write("w");
                        MessageBox.Show("obyvak slyšel, odešlo do arduina");
                        Thread.Sleep(22);
                        break;
                }
            }
        }
        public void SvetlaIN(string mistnost, string druhSvetla, string akce = "off")
        {

            if (mistnost == "vse")
            {
                Thread.Sleep(22);
                PrepniSvetlaPracovnaLustr(akce);
                Thread.Sleep(22);
                PrepniSvetlaChodbaLustr(akce);
                Thread.Sleep(22);
                PrepniSvetlaWCLustr(akce);
                Thread.Sleep(22);
                PrepniSvetlaKoupelnaLustr(akce);
                Thread.Sleep(22);
                PrepniSvetlaKuchynLustr(akce);
                Thread.Sleep(22);
                PrepniSvetlaObyvakLustr(akce);
                Thread.Sleep(22);
                PrepniSvetlaLozniceLustr(akce);
                return;
            }

            switch (mistnost)
            {
                case "chodba":
                    PrepniSvetlaChodbaLustr(akce);
                    break;
                case "pracovna":
                    PrepniSvetlaPracovnaLustr(akce);
                    break;
                case "WC":
                    PrepniSvetlaWCLustr(akce);
                    break;
                case "koupelna":
                    PrepniSvetlaKoupelnaLustr(akce);
                    break;
                case "kuchyn":
                    PrepniSvetlaKuchynLustr(akce);
                    break;
                case "obyvak":
                    PrepniSvetlaObyvakLustr(akce);
                    break;
                case "loznice":
                    PrepniSvetlaLozniceLustr(akce);
                    break;
            }
        }
        private void PrepniSvetlaPracovnaLustr(string akce)
        {
            if (akce == "on")
            {
                serialPort.Write("1");
            }
            else
            {
                serialPort.Write("0");
            }
        }
        private void PrepniSvetlaChodbaLustr(string akce)
        {
            if (akce == "on")
            {
                serialPort.Write("3");
            }
            else
            {
                serialPort.Write("2");
            }
        }
        private void PrepniSvetlaWCLustr(string akce)
        {
            if (akce == "on")
            {
                serialPort.Write("5");
            }
            else
            {
                serialPort.Write("4");
            }
        }
        private void PrepniSvetlaKoupelnaLustr(string akce)
        {
            if (akce == "on")
            {
                serialPort.Write("7");
            }
            else
            {
                serialPort.Write("6");
            }
        }
        private void PrepniSvetlaKuchynLustr(string akce)
        {
            if (akce == "on")
            {
                serialPort.Write("9");
            }
            else
            {
                serialPort.Write("8");
            }
        }
        private void PrepniSvetlaObyvakLustr(string akce)
        {
            if (akce == "on")
            {
                serialPort.Write("b");
            }
            else
            {
                serialPort.Write("a");
            }
        }
        private void PrepniSvetlaLozniceLustr(string akce)
        {
            if (akce == "on")
            {
                serialPort.Write("d");
            }
            else
            {
                serialPort.Write("c");
            }
        }
        private void SleepVlakno()
        {
            SvetlaIN("pracovna", "", "off");
            Thread.Sleep(22);
            SvetlaIN("wc", "", "off");
            Thread.Sleep(22);
            SvetlaIN("koupelna", "", "off");
            Thread.Sleep(22);
            SvetlaIN("kuchyn", "", "on");
            Thread.Sleep(22);
            SvetlaIN("obyvak", "", "off");
            Thread.Sleep(22);
            SvetlaIN("loznice", "", "on");
            Thread.Sleep(5000);
            SvetlaIN("chodba", "", "off");
            spravceZabezpeceni.StavZabezpeceni("sleep", "on");            
            Thread.Sleep(10000);
            SvetlaIN("kuchyn", "", "off");
        }
        public void DeaktivaceSleepVlakna()
        {

        }


        //------------------------------------------  ARDUINO     ARDUINO   ------------------------------------------  
        //------------------------------------------  ARDUINO     ARDUINO   ------------------------------------------  

        private void CtiArduino(object sender, EventArgs e) // metoda, která čte zprávu z arduina
        {
            if (serialPort.ReadLine() == null || serialPort.ReadLine().Length < 1)
                return;

                ArduinoText = serialPort.ReadLine().Trim().ToLower();
                // ZABEZPEČENÍ
                if (ZabezpeceniAktivovano)
                {
                    spravceZabezpeceni.KontrolaZabezpeceni(ArduinoText);
                }            

            if (!PoplachAktivovan)
            {
                // TEPLOTA
                if (ArduinoText.Length == 12 && ArduinoText.Contains("t") && ArduinoText.Contains("v"))
                {
                    int.TryParse(ArduinoText.Substring(1, 2), out ArduinoTeplota);
                    int.TryParse(ArduinoText.Substring(7, 2), out ArduinoVlhkost);
                }
            }                
        }

        public int VratTeplotu()
        {
            return ArduinoTeplota;
        }
        public int VratVlhkost()
        {
            return ArduinoVlhkost;
        }


        // ----------------------------------- METODY PŘI VYTVOŘENÍ       METODY PŘI VYTVOŘENÍ   -----------------------------------
        // ----------------------------------- METODY PŘI VYTVOŘENÍ       METODY PŘI VYTVOŘENÍ   -----------------------------------

        private void PripojitCidla()  // PŘIPOJENÍ K DESCE ARDUINO
        {
            try
            {
                serialPort.BaudRate = 9600;
                serialPort.PortName = "COM7"; // na tabletu je to levé USB.
                serialPort.Open();
                Thread.Sleep(300);
                MessageBox.Show("ARDUINO\n\nÚspěšné navázání komunikace s USB portem. \nArduino deska PŘIPOJENA, Mistie připravena k odesílání příkazů desce Arduino.");
                AktivaceCteniArduino();
                MessageBox.Show("ARDUINO\n\nAktivováno čtení z desky Arduino. \nMistie naslouchá informacím z desky Arduino.");

                //DefaultniNastaveniCidel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vyjímka:\n\n" + ex.Message + "\n\nNepodařilo se připojit program k desce Arduino. Zkontrolujte prosím správné připojení tabletu pomocí USB k desce Arduino.?\nProgram bude i přesto spuštěn ale nebude komunikovat s deskou Arduino.\n\nProsím restartujte Vaše zařízení, nebo kontaktujte servisní linku MN Software s.r.o. na tel. čísle +420 605 347 105");
            }
        }
        private void AktivaceCteniArduino() // Automatické opakování čtení zpáv z Arduina
        {
            try
            {
                DispatcherTimer timer = new DispatcherTimer();
                timer.Tick += new EventHandler(CtiArduino);
                timer.Interval = new TimeSpan(0, 0, 0, 15);
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vyjímka:\n" + ex.Message + "Nepodařilo se aktivovat čtení z Arduino desky. Mistie nenaslochá informací přicházejících z Arduino desky.");

            }
        }
        private void ZabezpeceniObjektOdesli()
        {
            spravceZabezpeceni.NactiSpravceCidel(this);
        }
    }
}
