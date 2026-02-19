using System.Windows;

namespace Group4337
{
    public partial class MainWindow : Window
    {
        public MainWindow()
            => InitializeComponent();

        private void Nigmatullina_4337_click(object sender, RoutedEventArgs e)
        {
            new _4337_Nigmatullina().ShowDialog();
        }
    }
}