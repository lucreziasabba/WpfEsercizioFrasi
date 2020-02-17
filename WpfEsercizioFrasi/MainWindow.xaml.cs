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
using System.IO;

namespace WpfEsercizioFrasi
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
        private const string file = "file.txt";
        string[] frasi = new string[5];
        int i = 0;
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            for(int i=0;i<5;i++)
            {
                frasi[i] = txtInsert.Text;
                if (i >= 5)
                {
                    btnStampa.IsEnabled = true;
                    btnPubblica.IsEnabled = true;
                }
            }
        }

        private void btnStampa_Click(object sender, RoutedEventArgs e)
        {
            for (i = 0; i < frasi.Length; i++)
            {
                lblFinito.Content += $"Posizione {i} : {frasi[i]} \n";
            }
        }

        private void btnPubblica_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writerfile = new StreamWriter(file, false, Encoding.UTF8);
            for (i = 0; i < frasi.Length; i++)
            {
                writerfile.WriteLine($" Posizione {i} : {frasi[i]} \n");
            }
        }

        private void btnOrdina_Click(object sender, RoutedEventArgs e)
        {
            for (i = 0; i < frasi.Length; i++)
                frasi.Sort(i);
        }
    }
}
