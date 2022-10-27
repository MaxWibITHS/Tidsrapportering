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

namespace Tidsrapportering
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ArbetsInfo> minLista = new List<ArbetsInfo>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            string namn = nameBox.Text;
            string datum = dateBox.Text;
            string start = ArbeteStartBox.Text;
            string end = ArbeteAvslutBox.Text;
            string arbete = WorkBox.Text;
            string kommentar = CommentBox.Text;

            ArbetsInfo nyttArbete = new ArbetsInfo(namn, datum, start, end, arbete, kommentar);
            minLista.Add(nyttArbete);

            
            MyListBox.Items.Add(nyttArbete.Date + " kl. " + nyttArbete.WorkStart + "-" + nyttArbete.WorkEnd + " Uppdrag: " + nyttArbete.WorkType + " Namn: " + nyttArbete.Name);    
            
        }

        private void MyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    }

