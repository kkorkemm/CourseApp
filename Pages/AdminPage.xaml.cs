using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace CourseApp.Pages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            TextHello.Text = $"Добро пожаловать,\n {CourseDBEntities.currentUser.FullName}!";
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти из системы?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CourseApp\login.txt";
                if (File.Exists(file))
                {
                    File.Delete(file);
                }

                Navigation.MainFrame.Navigate(new LoginPage());
            }
        }
    }
}
