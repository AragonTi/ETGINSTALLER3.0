using ETGINSTALLER3._0.Navigations;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ETGINSTALLER3._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void InstallBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new InstallPage());
        }

        private void VerifyBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new VerifyPage());
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ClearPage());
        }
    }
}