using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace CourseApp
{
    using Base;
    using Pages;

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CourseApp\login.txt";

            if (File.Exists(file))
            {
                try
                {
                    string login;

                    using (StreamReader sr = new StreamReader(file))
                    {
                        login = sr.ReadLine();
                        sr.Close();
                    }

                    CourseDBEntities.currentUser = CourseDBEntities.GetContext().User.Where(p => p.Login == login).FirstOrDefault();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (CourseDBEntities.currentUser == null)
            {
                MainFrame.Navigate(new LoginPage());
            }
            else
            {
                if (CourseDBEntities.currentUser.UserRoleID == 1)
                {
                    MainFrame.Navigate(new AdminPage());
                }
                else
                {
                    
                }
            }

            Navigation.MainFrame = MainFrame;
        }
    }
}
