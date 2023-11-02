using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GreenLumaGUI.Pages
{
    public partial class SettingsPage : Page
    {
        public string SteamPath, EditedSteamPath;

        public SettingsPage(string steamPath)
        {
            InitializeComponent();
            EditedSteamPath = steamPath;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.FrameMain.Navigate(new MainPage());
        }

        private void ApplyMainSettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainPage.SteamPath = EditedSteamPath;
        }

        private void BrowseSteamPathBtn_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Выберите папку"; // Устанавливаем описание для диалогового окна

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderDialog.SelectedPath;
                EditedSteamPath = selectedFolderPath;
                SteamPathTBX.Text = EditedSteamPath;
                SteamPathTBX.Select(SteamPathTBX.Text.Length, 0);
            }
        }
    }
}
