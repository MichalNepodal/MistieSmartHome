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

namespace Mistie_v_3.FrontEnd.Pages.Web
{
    /// <summary>
    /// Interaction logic for WebPage1.xaml
    /// </summary>
    public partial class WebPage1 : Page
    {
        MainWindow mainWindow;
        public WebPage1(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            //Nalad();
        }


        private void Nalad()
        {
            web.Source = new Uri("http://www.google.com");
        }
    }
}
