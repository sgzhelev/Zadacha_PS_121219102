using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoSystem
{
    class StudentData
    {
        static List<Student> _TestStudents = new List<Student>();
        static public List<Student> TestStudents
        {
            get
            {
                ResetTestStudentData();
                return _TestStudents;
            }
            private set { }
        }

        static private void ResetTestStudentData()
        {
            _TestStudents.Clear();

            _TestStudents.Add(new Student
            {
                FirstName = "Иван",
                SurName = "Иванов",
                LastName = "Иванов",
                Facultee = "ФКСТ",
                Specialtee = "КСИ",
                FacNumber = "121219110",
                Degree = StudentDegrees.BACHELOR,
                Course = 3,
                Group = 51,
                Stream = 9,
                Status = StudentStatus.Redoven,
                Username = "student1",
               
            });

            _TestStudents.Add(new Student
            {
                FirstName = "Драган",
                SurName = "Драганов",
                LastName = "Драганов",
                Facultee = "ФКСТ",
                Specialtee = "КСИ",
                FacNumber = "128219111",
                Degree = StudentDegrees.BACHELOR,
                Course = 6,
                Group = 51,
                Stream = 9,
                Status = StudentStatus.Prekasnap_po_uspeh,
                Username = "student2",
                
            });
            _TestStudents.Add(new Student
            {
                FirstName = "Кевин",
                SurName = "Кевинов",
                LastName = "Хаджиев",
                Facultee = "ФЕЕТ",
                Specialtee = "ЕТ",
                FacNumber = "125219112",
                Degree = StudentDegrees.BACHELOR,
                Course = 6,
                Group = 50,
                Stream = 15,
                Status = StudentStatus.Zadochno,
                Username = "student3",
                
            });
            _TestStudents.Add(new Student
            {
                FirstName = "Антон",
                SurName = "Антонов",
                LastName = "Антонов",
                Facultee = "ФКСТ",
                Specialtee = "ИТИ",
                FacNumber = "126219113",
                Degree = StudentDegrees.BACHELOR,
                Course = 7,
                Group = 21,
                Stream = 12,
                Status = StudentStatus.Samostoiatelna_podgotovka,
                Username = "student4",
                
            });
        }
    }
}
