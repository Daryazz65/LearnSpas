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
    /// Логика взаимодействия для SadovoeColcoWindow.xaml
    /// </summary>
    public partial class SadovoeColcoWindow : Window
    {
        public SadovoeColcoWindow()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            // ---.
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            AdditionalMaterialWindow additionalMaterialWindow = new AdditionalMaterialWindow();
            additionalMaterialWindow.Show();
            this.Close();
        }
    }
}
