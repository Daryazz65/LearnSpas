using System.Windows;

namespace LearnSpas.Windows
{
    /// <summary>
    /// Логика взаимодействия для BylvarnoeKolco.xaml
    /// </summary>
    public partial class BylvarnoeKolco : Window
    {
        public BylvarnoeKolco()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            AdditionalMaterialWindow additionalMaterialWindow = new AdditionalMaterialWindow();
            additionalMaterialWindow.Show();
            this.Close(); 
        }
              
    }
}
