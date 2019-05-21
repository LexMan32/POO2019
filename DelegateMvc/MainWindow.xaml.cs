using System.Windows;

namespace DelegateMvc
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Vue1 vue1;
        private Vue2 vue2;
        private Model model = new Model();

        public MainWindow()
        {
            InitializeComponent();

            vue1 = new Vue1(this);
            vue1.Show();
            vue2 = new Vue2(this);
            vue2.Show();
        }

        public Model GetModel()
        {
            return model;
        }
    }
}
