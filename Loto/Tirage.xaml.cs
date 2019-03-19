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

namespace Loto
{
    /// <summary>
    /// Logique d'interaction pour Tirage.xaml
    /// </summary>
    public partial class Tirage : UserControl
    {
        private List<int> valeurs;
        private double moyenne;
        private double variance;
        private double ecartType;

        public Tirage(int index)
        {
            InitializeComponent();

            valeurs = new List<int>();

            Random rnd = new Random();
            valeurs.Add(rnd.Next(0, 100));
            valeurs.Add(rnd.Next(0, 100));
            valeurs.Add(rnd.Next(0, 100));
            valeurs.Add(rnd.Next(0, 100));
            valeurs.Add(rnd.Next(0, 100));
            valeurs.Add(rnd.Next(0, 100));

            moyenne = 0;
            foreach (int valeur in valeurs)
            {
                moyenne = moyenne + valeur;
            }
            moyenne = moyenne / 6;

            variance = 0;

            ecartType = 0;

            lb_index.Content = index;
            lb_num1.Content = valeurs[0];
            lb_num2.Content = valeurs[1];
            lb_num3.Content = valeurs[2];
            lb_num4.Content = valeurs[3];
            lb_num5.Content = valeurs[4];
            lb_num6.Content = valeurs[5];
            lb_moyenne.Content = String.Format("{0:0.00}" , moyenne);
            lb_variance.Content = String.Format("{0:0.00}", variance);
            lb_ecartType.Content = String.Format("{0:0.00}", ecartType);
        }
    }
}
