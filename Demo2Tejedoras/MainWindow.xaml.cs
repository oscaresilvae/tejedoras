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
using Demo2Tejedoras.UC;
using System.IO;

namespace Demo2Tejedoras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += DemoMenu_Loaded;
        }

        private void DemoMenu_Loaded(object sender, RoutedEventArgs e)
        {
            UC.DemoMenu menu = new UC.DemoMenu();
            menu.sociasClick += menu_sociasClick;
            menu.legalClick += menu_legalClick;
            menu.filoClick += menu_filoClick;
            menu.actasClick += menu_actasClick;
            GridMain.Children.Add(menu);
        }

        void menu_sociasClick(object sender, EventArgs e)
        {
            GridMain.Children.Clear();
            UC.DemoSocias soci = new UC.DemoSocias();
            GridMain.Children.Add(soci);
        }

        void menu_legalClick(object sender, EventArgs e)
        {
            GridMain.Children.Clear();
            UC.DemoLegal lega = new UC.DemoLegal();
            GridMain.Children.Add(lega);
        }

        void menu_filoClick(object sender, EventArgs e) 
        {
            GridMain.Children.Clear();
            UC.DemoFilo fil = new UC.DemoFilo();
            GridMain.Children.Add(fil);
        }

        void menu_actasClick(object sender, EventArgs e)
        {
            GridMain.Children.Clear();
            UC.DemoActas acta = new UC.DemoActas();
            GridMain.Children.Add(acta);
        }
    }
}
