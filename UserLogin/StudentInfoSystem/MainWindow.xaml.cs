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
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Student Student { get; set; }
        public List<string> FaculteeList { get; set; }
        
        public MainWindow(object DContext)
        {
            InitializeComponent();
            Student = DContext as Student;
            this.DataContext = DContext;

            InitFacDropdown();

            FillStudStatusChoices();
        }

        private void InitFacDropdown()
        {
            var query = from student in StudentData.TestStudents group student by student.Facultee into fak orderby fak.Key select fak;
            //FaculteeList.Clear();
            FaculteeList = new List<string>();
            foreach (var fakultet in query)
            {
                FaculteeList.Add(fakultet.Key);
            }
        }



        private void bntClear_Click(object sender, RoutedEventArgs e)
        {
            EnableControls(false, true);
        }

        private void bntShowData_Click(object sender, RoutedEventArgs e)
        {
            this.Student = StudentData.TestStudents[0];
            DisplayStudentData();
        }

        private void bntEnableAll_Click(object sender, RoutedEventArgs e)
        {
            EnableControls(true, false);
        }

        private void bntDisableAll_Click(object sender, RoutedEventArgs e)
        {
            EnableControls(false, false);
        }
        private void EnableControls(bool enadbled, bool clear)
        {
            foreach (UIElement item in PersonalData.Children)
            {
                if (item is TextBox)
                {
                    if (clear)
                    {
                        ((TextBox)item).Text = "";
                    }
                    if (item.IsEnabled != enadbled)
                    {
                        ((TextBox)item).IsEnabled = enadbled;
                    }
                }
            }

            foreach (UIElement item in StudentInfo.Children)
            {
                if (item is TextBox)
                {
                    if (clear)
                    {
                        ((TextBox)item).Text = "";
                    }
                    if (item.IsEnabled != enadbled)
                    {
                        ((TextBox)item).IsEnabled = enadbled;
                    }
                }
            }
        }

        public void DisplayStudentData()
        {
            //Student = StudentData.TestStudents[0];
            if (Student != null)
            {
                
                tbFirstName.Text = Student.FirstName;
                tbSurName.Text = Student.SurName;
                tbLastName.Text = Student.LastName;

                tbFacultee.Text = Student.Facultee;
                tbSpecialtee.Text = Student.Specialtee;
                tbDegree.Text = Student.Degree.ToString();
                tbStatusComboBox.Text = Student.Status.ToString();
                tbFacNumber.Text = Student.FacNumber;
                tbGroup.Text = Student.Group.ToString();
                tbPotok.Text = Student.Stream.ToString();
                tbCourse.Text = Student.Course.ToString();
                


                EnableControls(true, false);
            }
            else
            {
                EnableControls(false, true);
                MessageBox.Show("No valid data to display!");
            }
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to logout?", "Logout?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                LoginWindow loginWindow = new LoginWindow();
                this.Close();
                loginWindow.Show();
            }
        }

        public List<string> StudStatusChoices { get; set; }
        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            /*SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LTJNAKR\\SQLEXPRESS;Initial Catalog=StudentInfoDatabase;Integrated Security=True");
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open) {
                string query = "SELECT StatusDescr FROM dbo.StudStatus;";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
            }
            */
            using (IDbConnection connection = new
            SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery =
                "SELECT StatusDescr FROM StudStatus;";
                //"DELETE FROM StudStatus WHERE id=5";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                SqlDataReader reader = (SqlDataReader)command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)
                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    notEndOfResult = reader.Read();
                }
            }
            
        }

        private void tbStatusComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void btnLoad_Click_1(object sender, RoutedEventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                imgStudent.Source = new BitmapImage(new Uri(op.FileName));
            }
        }
    }   

}
