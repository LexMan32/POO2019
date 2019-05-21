using System.Windows;
using System.Windows.Controls;

namespace DelegateMvc
{
    /// <summary>
    /// Logique d'interaction pour Vue2.xaml
    /// </summary>
    public partial class Vue2 : Window
    {
        private MainWindow controleur;

        public Vue2(MainWindow controleur)
        {
            this.controleur = controleur;
            controleur.GetModel().SurChangementValeur += Affiche;

            InitializeComponent();
        }

        private void Affiche(string text)
        {
            txbVue2.Text = text;
        }

        private void txbVue2_TextChanged(object sender, TextChangedEventArgs e)
        {
            controleur.GetModel().Text = txbVue2.Text;
        }
    }
}
