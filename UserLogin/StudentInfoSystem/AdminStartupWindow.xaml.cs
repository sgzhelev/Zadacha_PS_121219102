using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for AdminStartupWindow.xaml
    /// </summary>
    public partial class AdminStartupWindow : Window
    {
        public AdminStartupWindow()
        {
            InitializeComponent();
            ListStudents();
            ListUsers();
        }

        private void ListUsers()
        {
            int uid = 100;
            foreach (User user in UserData.TestUsers)
            {
                lvSystemUsers.Items.Add(new UserListItem { Id = uid, Name = user.Username, UserRole = user.Role.ToString() });
                uid++;
            }
        }

        private void ListStudents()
        {

            foreach (Student student in StudentData.TestStudents)
            {
                string getFullName(Student student)
                {
                    string firstName = student.FirstName.Trim();
                    string surName = student.SurName.Trim();
                    string lastName = student.LastName.Trim();

                    return firstName + " " + (String.IsNullOrEmpty(surName) ? "" : (surName + " ")) + lastName;
                }

                lvStudents.Items.Add(
                    new StudentListItem
                    {
                        FacNumber = student.FacNumber,
                        FullName = getFullName(student),
                        OKS = student.Degree.ToString(),
                        Specialty = student.Specialtee,
                        Facultee = student.Facultee,
                        Course = student.Course,
                        Group = student.Group,
                        Potok = student.Stream
                    });

            }
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvStudents.Items);
            view.SortDescriptions.Add(new SortDescription("FacNumber", ListSortDirection.Ascending));
        }

        private void lvStudents_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //StudentListItem item = (StudentListItem)(sender as ListView).SelectedItem;
            //MainWindow mainWindow = new MainWindow();

            var item = (sender as ListView).SelectedItem;

            MessageBox.Show("Item count = " + item.ToString());
            //mainWindow.Student = from student in StudentData.TestStudents where student.FacNumber.Contains(item.bid);
            //mainWindow.Show();
        }

        private void lvStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StudentListItem item = (StudentListItem)(sender as ListView).SelectedItem;
            if (item != null)
            {
                IEnumerable<Student> act = (from student in StudentData.TestStudents where student.FacNumber.Contains(item.FacNumber) select student);
                //mainWindow.Student = act.First();
                MainWindow mainWindow = new MainWindow(act.First());
                //mainWindow.DisplayStudentData();
                mainWindow.Show();
            }

        }
    }

    public class UserListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserRole { get; set; }
    }
    public class StudentListItem
    {
        public string FacNumber { get; set; }
        public string FullName { get; set; }
        public string OKS { get; set; }
        public string Facultee { get; set; }
        public string Specialty { get; set; }
        public int Potok { get; set; }
        public int Group { get; set; }
        public int Course { get; set; }

    }
}
