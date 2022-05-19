using System;
using System.Collections.Generic;
using System.Text;
using UserLogin;

namespace StudentInfoSystem
{
    public class StudentValidation
    {
        public delegate void ActionOnError(string errorMsg);
        private ActionOnError actionOnError;

        public StudentValidation() { }

        public string StatusMsg { get; private set; }
        public Student GetStudentDataByUser(User user, ActionOnError actionOnError)
        {

            if (String.IsNullOrEmpty(user.FakNum))
            {
                this.StatusMsg = "Faculty number is empty!";
                actionOnError(this.StatusMsg);
                return null;
            }

            foreach (Student student in StudentData.TestStudents)
            {
                if (user.Username.Equals(student.Username))
                {
                    return student;
                }
            }

            this.StatusMsg = "No matching students!";
            actionOnError(this.StatusMsg);
            return null;
        }
    }
}
