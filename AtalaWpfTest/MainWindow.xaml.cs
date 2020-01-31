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

namespace AtalaWpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnOpenFile(object sender, RoutedEventArgs e)
        {
            //this.Viewer.Image = new Atalasoft.Imaging.AtalaImage("pack://application:,,,/Resources/porsiyon1.png");
            this.Viewer.Image = new Atalasoft.Imaging.AtalaImage(@"C:\Users\KARA\Source\Repos\AtalaWpfTest\AtalaWpfTest\Resources\ofis_1.jpg");
            //this.Viewer.Image = new Atalasoft.Imaging.AtalaImage(@"Resources\ofis_1.jpg");
        }
        private void OnSaveFile(object sender, RoutedEventArgs e)
        {

        }
        private void OnExit(object sender, RoutedEventArgs e)
        {


        }
    }
}
