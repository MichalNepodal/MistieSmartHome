using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows;
using System.Windows.Threading;

namespace Mistie_v_3.BackEnd
{
    public class ArduinoCtecka
    {
    }

    //    SerialPort myport;

    //    string AktualniTextArduino;
    //    List<string> seznamTextuArduino;
    //    public ArduinoCtecka()
    //    {
    //        seznamTextuArduino = new List<string>();
    //        //NastavitPort();

    //        DispatcherTimer timer = new DispatcherTimer();
    //        timer.Tick += new EventHandler(CtiArduino);
    //        timer.Interval = new TimeSpan(0, 0, 3); 
    //        timer.Start();

    //        DispatcherTimer zkouska = new DispatcherTimer();
    //        timer.Tick += new EventHandler(ZkontrolujAktivaci);
    //        timer.Interval = new TimeSpan(0, 0, 30);
    //        timer.Start();

    //    }

    //    private void ZkontrolujAktivaci(object sender, EventArgs e)
    //    {
    //        foreach (string slovo in seznamTextuArduino)
    //        {
    //            if (slovo == "Aktivovano")
    //                MessageBox.Show("Nalezeno Aktivování, spouštím oplach!!!");
    //        }
    //        MessageBox.Show("Nenalezeno nic, konec hledání");
    //    }

    //    private void CtiArduino(object sender, EventArgs e)
    //    {
    //        AktualniTextArduino = myport.ReadLine().Trim();
    //        seznamTextuArduino.Add(AktualniTextArduino);
    //    }

    //    private void NastavitPort()
    //    {
    //        try
    //        {
    //            myport = new SerialPort();
    //            myport.BaudRate = 9600;
    //            myport.PortName = "COM6";
    //            myport.Open();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Vyjímka\n\n" + ex.Message + "\n\nPort k Arduinu, který má za úkol přijímat a číst příchozí kódy z Arduina, nebyl úspěště připojen." +
    //                "\nZkontrolujte prosím zapojení Arduina k zařízení a správné pojmenování portu např. ('COM6')." +
    //                "\nProgram bude fungovat, ale bezpečnostní systémy a další komunikace, jsou nefunkční");
    //        }
    //    }
    //}
}
