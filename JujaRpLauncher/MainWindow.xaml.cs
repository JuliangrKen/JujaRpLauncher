using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JujaRpLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int NumberBackground = 4;

        public MainWindow()
        {
            InitializeComponent();
            MainBackgroundShow();
        }

        private void MainBackgroundShow()
        {
            var rnd = new Random();
            var result = rnd.Next(1, NumberBackground);

            string selectedFileName = $"/Resources/background{result}.jpg";

            var bitmap = new BitmapImage();

            bitmap.BeginInit();
            bitmap.UriSource = new Uri(selectedFileName, UriKind.Relative);
            bitmap.EndInit();

            MainBackground.Source = bitmap;
        }

        private void ConnectToServerButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", "steam://connect/185.221.196.85:27015");
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
            => Close();
    }
}
