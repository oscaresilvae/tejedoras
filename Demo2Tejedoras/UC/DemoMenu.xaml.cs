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

namespace Demo2Tejedoras.UC
{
    /// <summary>
    /// Interaction logic for DemoMenu.xaml
    /// </summary>
    public partial class DemoMenu : UserControl
    {
        public DemoMenu()
        {
            InitializeComponent();
        }

        public event EventHandler sociasClick;
        public event EventHandler legalClick;
        public event EventHandler filoClick;
        public event EventHandler actasClick;

        private void socias_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
          if(sociasClick!=null)
          {
              sociasClick(sender, null);
          }
        }

        private void legal_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(legalClick!=null)
            {
                legalClick(sender, null);
            }
        }

        private void filosofía_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(filoClick!=null)
            {
                filoClick(sender, null);
            }
        }

        private void actas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(actasClick!=null)
            {
                actasClick(sender, null);
            }
        }

    }
}
