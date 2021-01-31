using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Windows;

namespace Mistie_v_3.BackEnd
{
    public class Mistie
    {
        // Speech To Text
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices clist = new Choices();

        //Class
        SpravceCidel spravceCidel;
        SpravceHudby spravceHudby;
        MainWindow mainWindow;

        private bool OvladaniHlasemAktivovano { get; set; }

        bool mistieLisening = false;
        string posledniSLovo = "";
        string aktualniSlovo = "";

        public Mistie(MainWindow mainWindow, SpravceCidel spravceCidel, SpravceHudby spravceHudby)
        {
            this.mainWindow = mainWindow;
            this.spravceCidel = spravceCidel;
            this.spravceHudby = spravceHudby;
            OvladaniHlasemAktivovano = false;
        }

        // AKTIVACE / DEAKTIVACE
        // AKTIVACE / DEAKTIVACE
        public void ZapnoutOvladaniHlasem(string stav)
        {
            if(stav == "on")
            {
                if(!OvladaniHlasemAktivovano)
                    AktivovatOvladaniHlasem();
            }
            if (stav == "off")
            {
                if (OvladaniHlasemAktivovano)
                {
                    sre.RecognizeAsyncStop();
                    OvladaniHlasemAktivovano = false;
                    mainWindow.MicrophoneOpacity(0.1);
                }                    
            }
        }
        public void AktivovatOvladaniHlasem()
        {
            clist.Add(new string[] { "mistie", "televize", "on", "off", "light", "music", "nothing", "livingroom", "lampa", "strop", "dekoration", "everithing" });
            Grammar gr = new Grammar(new GrammarBuilder(clist));

            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += AnalizaHlasu;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
                OvladaniHlasemAktivovano = true;
                mainWindow.MicrophoneOpacity(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, nepodařilo se aktivovat Mistie Speech To Text.");
            }
        }

        // INTERNÍ METODA ANALÝZY HLASU
        // INTERNÍ METODA ANALÝZY HLASU
        void AnalizaHlasu(object sender, SpeechRecognizedEventArgs e)
        {
            aktualniSlovo = e.Result.Text.ToString();
            //mainWindow.mistieSayTextBlock.Text = aktualniSlovo;

            if (!mistieLisening)
            {
                if (aktualniSlovo == "mistie")
                {
                    mistieLisening = true;
                    spravceHudby.PlaySayYes();
                    return;
                }
                else
                    mistieLisening = false;
            }

            if (mistieLisening)
            {
                if (aktualniSlovo == "nothing")
                {
                    spravceHudby.SayNothing();
                    mistieLisening = false;
                    return;
                }
                if (aktualniSlovo == "music" || posledniSLovo == "music")
                {
                    Music(aktualniSlovo);
                    return;
                }

                if (aktualniSlovo == "light" || posledniSLovo == "light" || posledniSLovo == "livingroom")
                {
                    Light(aktualniSlovo);
                    return;
                }

                if (aktualniSlovo == "televize" || posledniSLovo == "televize")
                {
                    Televize(aktualniSlovo);
                    return;
                }
            }
        }

        private void Light(string slovo)
        {
            if (aktualniSlovo == "light")
                posledniSLovo = "light";

            if (posledniSLovo == "light" || posledniSLovo == "livingroom")
            {
                if (aktualniSlovo == "on")
                {
                    spravceHudby.SayLightsOn();
                    spravceCidel.SvetlaIN("vse", "", "on");
                    mistieLisening = false;
                }
                if (aktualniSlovo == "off")
                {
                    spravceHudby.SayLightsOff();
                    spravceCidel.SvetlaIN("vse", "", "off");
                    mistieLisening = false;
                }

                if (aktualniSlovo == "livingroom" || posledniSLovo == "livingroom")
                {
                    posledniSLovo = "livingroom";

                    if (aktualniSlovo == "everithing")
                    {

                        spravceCidel.SvetlaIN("obyvak", "vše");
                        mistieLisening = false;
                    }
                    if (aktualniSlovo == "lampa")
                    {
                        spravceCidel.SvetlaIN("obyvak", "lampa");
                        mistieLisening = false;
                    }
                    if (aktualniSlovo == "dekoration")
                    {
                        spravceCidel.SvetlaIN("obyvak", "dekorace");
                        mistieLisening = false;
                    }
                    if (aktualniSlovo == "strop")
                    {
                        spravceCidel.SvetlaIN("obyvak", "lustr");
                        mistieLisening = false;
                    }
                }
            }
        }
        private void Music(string slovo)
        {
            posledniSLovo = "music";
            if (posledniSLovo == "music")
            {
                if (aktualniSlovo == "on")
                {
                    spravceHudby.PlaySayHudba();
                    spravceHudby.PlayMusic();
                    posledniSLovo = "";
                    mistieLisening = false;
                }
                if (aktualniSlovo == "off")
                {
                    spravceHudby.StopMusic();
                    posledniSLovo = "";
                    mistieLisening = false;
                }
            }
        }
        private void Televize(string slovo)
        {
            posledniSLovo = "televize";

            if (posledniSLovo == "televize")
            {
                if (aktualniSlovo == "on")
                {
                    MessageBox.Show("Televize on");
                    mistieLisening = false;
                }
                if (aktualniSlovo == "off")
                {
                    MessageBox.Show("Televize off");
                    mistieLisening = false;
                }
            }
        }
    }
}



   
