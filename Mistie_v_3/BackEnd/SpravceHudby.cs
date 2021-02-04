using Mistie_v_3.BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Mistie_v_3
{
    public class SpravceHudby
    {
        SpravceZabezpeceni spravceZabezpeceni;
        Random random = new Random();
        SoundPlayer soundPlayer;

        public SpravceHudby(SpravceZabezpeceni spravceZabezpeceni)
        {
            this.spravceZabezpeceni = spravceZabezpeceni;
            PosliSeSpravciZabezpeceni();
        }


        // SPUŠTĚNÍ HUDBY
        // SPUŠTĚNÍ HUDBY

        public void StopMusic()
        {
            if (soundPlayer != null)
                soundPlayer.Stop();                
        }
        public void PlayMusic()
        {
            soundPlayer = new SoundPlayer(@"C:\Mistie\Mistie_v_3\Music\music1.wav");
            soundPlayer.Play();
        }

        // HLASOVÉ ODPOVĚDI
        // HLASOVÉ ODPOVĚDI

        public void PlaySayYes()
        {
            if (NahodneCislo() == 0)
                soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\Jo.wav");
            else
                soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\Jo2.wav");
            soundPlayer.Play();
        }
        public void PlaySayHudba()
        {
            if (NahodneCislo() == 0)
                soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\PoustimHudbu.wav");
            else
                soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\PoustimHudbu2.wav");
            soundPlayer.Play();
            Thread.Sleep(1500);
        }
        public void SayLightsOn()
        {
            if (NahodneCislo() == 0)
                soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\Rozsvicuji.wav");
            else
                soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\Rozsvicuji2.wav");
            soundPlayer.Play();
            Thread.Sleep(1000);
        }
        public void SayLightsOff()
        {
            if (NahodneCislo() == 0)
                soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\Zhasinam.wav");
            else
                soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\Zhasinam2.wav");
            soundPlayer.Play();
            Thread.Sleep(1000);
        }
        public void SayNothing()
        {
            soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\Nic1.wav");
            soundPlayer.Play();
            Thread.Sleep(1000);
        }
        public void PrichodOdemceni()
        {
            soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\OdemcenoPrichod1.wav");
            soundPlayer.Play();
        }
        public void OdchodUzamceni()
        {
            soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\UzamykamOdchod1.wav");
            soundPlayer.Play();
        }
        public void Deaktivace()
        {            
            soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\Deaktivace1.wav");
            soundPlayer.Play();
        }
        public void AktivaceVnejsiOchrana()
        {
            soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\AktivaceVnesjiZabezpeceni1.wav");
            soundPlayer.Play();
        }
        public void AktivaceRezimSpanek()
        {
            soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\AktivaceRezimSpanek1.wav");
            soundPlayer.Play();
        }
        public void DeaktivaceBezpecnostniSystem()
        {
            soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\DeaktivaceBezpecnostniSystem1.wav");
            soundPlayer.Play();
        }
        public void AktivaceBezpecnostniSystem()
        {
            soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\AktivaceBezpecnostniSystem1.wav");
            soundPlayer.Play();
        }

        public void ZvukNespravnehoHesla()
        {
            soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\spatneHeslo1.wav");
            soundPlayer.Play();
        }
        public void ZvukSpravnehoHesla()
        {
            soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\spravneHeslo1.wav");
            soundPlayer.Play();
        }
        public void ZvukAlarm1()
        {
            soundPlayer = new SoundPlayer(@"D:\MistieSmartHome\Mistie_v_0.07_31_1_2021\Mistie_v_3\Sounds\alarm1.wav");
            soundPlayer.Play();
        }

        // INTERNÍ METODY 
        // INTERNÍ METODY 
        private int NahodneCislo()
        {
            return random.Next(2);
        }

        // METODA PRI VYTVORENI

        private void PosliSeSpravciZabezpeceni()
        {
            spravceZabezpeceni.NactiSpravceHudby(this);
        }
    }
}
