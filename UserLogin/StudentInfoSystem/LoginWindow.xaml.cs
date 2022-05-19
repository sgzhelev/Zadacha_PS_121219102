using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UserLogin;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginValidation loginValidation = new LoginValidation(tbUsrename.Text, tbPassword.Password, showErrorMessage);
            User user = null;

            if (loginValidation.ValidateUserInput(ref user))
            {
                if (user != null)
                {
                    if (LoginValidation.currentUserRole == UserRoles.STUDENT)
                    {
                        StudentValidation studentValidation = new StudentValidation();

                        Student student = studentValidation.GetStudentDataByUser(user, showErrorMessage);
                        if (student != null)
                        {
                            var mainWindow = new MainWindow(student);
                            this.Close();
                            mainWindow.Show();
                        }
                        //mainWindow.DisplayStudentData();
                    }
                    else if (LoginValidation.currentUserRole == UserRoles.ADMIN)
                    {
                        var adminStartupWindow = new AdminStartupWindow();
                        this.Close();
                        adminStartupWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("You are not a STUDENT");
                    }
                }
            }

            void showErrorMessage(string errorMessage)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
