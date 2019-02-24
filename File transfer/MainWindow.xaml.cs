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


namespace File_transfer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        file_selector _file_sel;
        lan_scaner _lan_scan;

        public MainWindow()
        {
            InitializeComponent();
            _file_sel = new file_selector();
            _lan_scan = new lan_scaner();
        }

        private void Select_file_Click(object sender, RoutedEventArgs e)
        {
            _file_sel.Open_FileDialog();
        }

        private void Destination_Click(object sender, RoutedEventArgs e)
        {
            _lan_scan.scan_lan_ip();
        }
    }
}
