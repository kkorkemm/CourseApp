using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace CourseApp.Pages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TextLogin.Text))
                errors.AppendLine("Введите логин");
            if (string.IsNullOrWhiteSpace(TextPass.Password))
                errors.AppendLine("Введите пароль");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                var user = CourseDBEntities.GetContext().User.Where(p => p.Login == TextLogin.Text).FirstOrDefault();

                if (user == null)
                {
                    MessageBox.Show("Нет такого пользователя", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    if (user.Password != TextPass.Password)
                    {
                        MessageBox.Show("Неверный пароль!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    else
                    {
                        CourseDBEntities.currentUser = user;

                        /// REMEMBER ME
                        if (CheckRemember.IsChecked == true)
                        {
                            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CourseApp";
                            Directory.CreateDirectory(folder);

                            try
                            {
                                using (StreamWriter sw = new StreamWriter(folder + @"\login.txt", false, Encoding.Default))
                                {
                                    sw.WriteLine(user.Login);
                                    sw.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }

                        if (user.UserRoleID == 1)
                        {
                            Navigation.MainFrame.Navigate(new AdminPage());
                        }
                    }
                }
            }
        }
    }
}
