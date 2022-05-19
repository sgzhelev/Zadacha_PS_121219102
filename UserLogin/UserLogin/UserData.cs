using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class UserData
    {
        static List<User> _TestUsers = new List<User>(2);
        static public List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _TestUsers;
            }
            set { }
        }

        static private void ResetTestUserData()
        {
            //if(_TestUsers == null)
            //{
            _TestUsers.Clear();

            _TestUsers.Add(new User
            {
                Username = "admin",
                Password = "admin",
                FakNum = "121219100",
                Role = UserRoles.ADMIN
            });

            _TestUsers.Add(new User
            {
                Username = "student1",
                Password = "student",
                FakNum = "121219101",
                Role = UserRoles.STUDENT
            });
            _TestUsers.Add(new User
            {
                Username = "student2",
                Password = "student",
                FakNum = "121219021",
                Role = UserRoles.STUDENT
            });

            _TestUsers.Add(new User
            {
                Username = "student3",
                Password = "student",
                FakNum = "121219021",
                Role = UserRoles.STUDENT
            });
            _TestUsers.Add(new User
            {
                Username = "professor1",
                Password = "professor",
                FakNum = "121219101",
                Role = UserRoles.PROFESSOR
            });
            //}
        }

        static public User IsUserPassCorrect(string username, string password)
        {
            //foreach (User user in TestUsers){
            //    if (username.Equals(user.Username) && password.Equals(user.Password))
            //    {
            //        return user;
            //    }
            //}
            //return null;

            return (from testUser in UserData.TestUsers where testUser.Username.Equals(username) && testUser.Password.Equals(password) select testUser).FirstOrDefault();
        }

        public static void SetUserActiveTo(string username, DateTime dt)
        {
            foreach (User user in _TestUsers)
            {
                if (username.Equals(user.Username))
                {
                    user.ActiveUntil = dt;
                    Logger.LogActivity("Changed user '" + username + "' `active to` date to " + dt.ToString("dd/MM/yyyy"));
                }
            }
        }

        public static void AssignUserRole(string username, UserRoles role)
        {
            foreach (User user in _TestUsers)
            {
                if (username.Equals(user.Username))
                {
                    user.Role = role;
                    Logger.LogActivity("Changed user '" + username + "' `role` to " + role);
                }
            }
        }
    }
}
