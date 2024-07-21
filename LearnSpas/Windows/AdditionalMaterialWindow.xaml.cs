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

namespace LearnSpas.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdditionalMaterialWindow.xaml
    /// </summary>
    public partial class AdditionalMaterialWindow : Window
    {
        public AdditionalMaterialWindow()
        {
            InitializeComponent();
        }

        private void LearnBtn_Click(object sender, RoutedEventArgs e)
        {
            StartWindow startWindow = new StartWindow();
            startWindow.Show();
            this.Close();
        }

        private void DopMaterialBtn_Click(object sender, RoutedEventArgs e)
        {
            // ---. 
        }

        private void ProfilBtn_Click(object sender, RoutedEventArgs e)
        {
            ProfilWindow profilWindow = new ProfilWindow();
            profilWindow.Show();
            this.Close();
        }

        private void BylvarBtn_Click(object sender, RoutedEventArgs e)
        {
            BylvarnoeKolco bylvarnoeKolco = new BylvarnoeKolco();
            bylvarnoeKolco.Show();
            this.Close();
        }

        private void SadovBtn_Click(object sender, RoutedEventArgs e)
        {
            SadovoeColcoWindow sadovoeColcoWindow = new SadovoeColcoWindow();
            sadovoeColcoWindow.Show();
            this.Close();
        }

        private void TtkBtn_Click(object sender, RoutedEventArgs e)
        {
            TtkWindow ttkWindow = new TtkWindow();
            ttkWindow.Show();
            this.Close();
        }

        private void MkadBtn_Click(object sender, RoutedEventArgs e)
        {
            MkadWindow mkadWindow = new MkadWindow();
            mkadWindow.Show();
            this.Close();
        }

        private void YauzaBtn_Click(object sender, RoutedEventArgs e)
        {
            // ---.
        }
    }
}
