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
using System.Windows.Shapes;
using static MVCAppli.App;

namespace MVCAppli
{
    /// <summary>
    /// Logique d'interaction pour Saisie2.xaml
    /// </summary>
    public partial class Saisie2 : Window
    {
        public SetTbSaisieDelegate setTbSaisieDelegateCallback;

        public Saisie2()
        {
            InitializeComponent();
        }

        private void tbSaisie2_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
