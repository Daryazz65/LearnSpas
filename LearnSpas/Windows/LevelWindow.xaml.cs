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
    /// Логика взаимодействия для LevelWindow.xaml
    /// </summary>
    public partial class LevelWindow : Window
    {
        public LevelWindow()
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

        private void StrelkaCloseModulOneBtn_Click(object sender, RoutedEventArgs e)
        {
            // ---.
        }

        private void VozvratModulBtn_Click(object sender, RoutedEventArgs e)
        {
            StartWindow startWindow = new StartWindow();
            startWindow.Show();
            this.Close();
        }

        private void LevelOneBtn_Click(object sender, RoutedEventArgs e)
        {
            ModalOneLevelOne modalOneLevelOne = new ModalOneLevelOne();
            modalOneLevelOne.Show();
            this.Close();
        }

        private void LevelTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            ModalOneLevelTwo modalOneLevelTwo = new ModalOneLevelTwo();
            modalOneLevelTwo.Show();
            this.Close();
        }

        private void LevelThreeBtn_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
