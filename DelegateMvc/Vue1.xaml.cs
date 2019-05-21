using System.Windows;
using System.Windows.Controls;

namespace DelegateMvc
{
    /// <summary>
    /// Logique d'interaction pour Vue1.xaml
    /// </summary>
    public partial class Vue1 : Window
    {
        private MainWindow controleur;

        public Vue1(MainWindow controleur)
        {
            this.controleur = controleur;
            controleur.GetModel().SurChangementValeur += Affiche;

            InitializeComponent();
        }

        private void Affiche(string text)
        {
            txbVue1.Text = text;
        }

        private void txbVue1_TextChanged(object sender, TextChangedEventArgs e)
        {
            controleur.GetModel().Text = txbVue1.Text;
        }
    }
}
