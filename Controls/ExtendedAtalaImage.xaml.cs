using Microsoft.Win32;
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

namespace Controls
{
    /// <summary>
    /// Interaction logic for ExtendedAtalaImage.xaml
    /// </summary>
    public partial class ExtendedAtalaImage : UserControl
    {
        public ExtendedAtalaImage()
        {
            InitializeComponent();
        }


        private void OnOpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();

            f.Multiselect = false;
            if (f.ShowDialog() == true)
            {
                this.Viewer.Image = new Atalasoft.Imaging.AtalaImage(f.FileName);
            }
        }
        private void OnSaveFile(object sender, RoutedEventArgs e)
        {

        }
        private void OnExit(object sender, RoutedEventArgs e)
        {


        }
    }
}
