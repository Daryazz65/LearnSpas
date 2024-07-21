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
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void LearnBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DopMaterialBtn_Click(object sender, RoutedEventArgs e)
        {
            AdditionalMaterialWindow additionalMaterialWindow = new AdditionalMaterialWindow();
            additionalMaterialWindow.Show();
            this.Close();
        }

        private void ProfilBtn_Click(object sender, RoutedEventArgs e)
        {
            ProfilWindow profilWindow = new ProfilWindow();
            profilWindow.Show();
            this.Close();
        }

        private void ModulOneBtn_Click(object sender, RoutedEventArgs e)
        {
            LevelWindow levelWindow = new LevelWindow();
            levelWindow.Show();
            this.Close();
        }

        private void ModulTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            LevelTwoWindow levelTwoWindow = new LevelTwoWindow();
            levelTwoWindow.Show();
            this.Close();
        }
    }
}
