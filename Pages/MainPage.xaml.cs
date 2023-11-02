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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GreenLumaGUI.Pages
{
    public partial class MainPage : Page
    {
        public static string SteamPath;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.FrameMain.Navigate(new SettingsPage(SteamPath));
        }

        private void TestBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!SteamPath.Contains("Steam") || SteamPath == "" || SteamPath == String.Empty || SteamPath == null)
            {
                MessageBox.Show("Путь до папки Steam не указан!");
                FrameApp.FrameMain.Navigate(new SettingsPage(SteamPath));
            }
            else
            {
                MessageBox.Show($"SteamPath: {SteamPath}");
            }
        }
    }
}
