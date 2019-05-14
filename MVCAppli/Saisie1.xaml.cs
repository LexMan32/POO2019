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
using static MVCAppli.App;

namespace MVCAppli
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class Saisie1 : Window
    {
        public SetTbSaisieDelegate setTbSaisieCallback;

        public Saisie1()
        {
            InitializeComponent();
            this.SetParame

            Saisie2 saisie2 = new Saisie2();
            saisie2.Show();
        }

        private void tbSaisie1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        public void SetTb
    }
}
