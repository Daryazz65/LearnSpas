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
    /// Логика взаимодействия для ModalOneLevelOne.xaml
    /// </summary>
    public partial class ModalOneLevelOne : Window
    {
        private const string V = "Правильно";

        public ModalOneLevelOne()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            LevelWindow levelWindow = new LevelWindow();
            levelWindow.Show(); 
            this.Close();
        }

        private void NepravlBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Неправильно!");

        }

        private void PravilBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Правильно!");
        }

        private void NepravBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Неправильно!");

        }

        private void PropustitBtn_Click(object sender, RoutedEventArgs e)
        {
            // ---.
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            ModalOneLevelOnee modalOneLevelOnee = new ModalOneLevelOnee();
            modalOneLevelOnee.Show();
            this.Close();
        }
    }
}
