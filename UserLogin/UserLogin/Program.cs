using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        static void Administrator()
        {
            Console.WriteLine("Изберете опция:");
            Console.WriteLine("0: Изход");
            Console.WriteLine("1: Промяна на роля на потребител");
            Console.WriteLine("2: Промяна на активност на потребител");
            Console.WriteLine("3: Списък на потребителите");
            Console.WriteLine("4: Преглед на лог активност");
            Console.WriteLine("5: Преглед на текуща активност");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    {
                        Environment.Exit(0);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Въведете име на потребител: ");
                        string username = Console.ReadLine();
                        Console.WriteLine("Роли:");
                        Console.WriteLine("1. ANONYMOUS");
                        Console.WriteLine("2. ADMIN");
                        Console.WriteLine("3. INSPECTOR");
                        Console.WriteLine("4. PROFESSOR");
                        Console.WriteLine("5. STUDENT");
                        Console.WriteLine("Въведете роля: ");
                        UserRoles role = (UserRoles)(Convert.ToInt32(Console.ReadLine()) - 1);
                        UserData.AssignUserRole(username, role);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Въведете име на потребител: ");
                        string username = Console.ReadLine();
                        Console.WriteLine("Въведете дата на активност (dd/MM/yyyy): ");
                        string dateInput = Console.ReadLine();
                        //DateTime dt = Convert.ToDateTime(Console.ReadLine());
                        DateTime dt;
                        while (!DateTime.TryParseExact(dateInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
                        {
                            Console.WriteLine("Invalid date, please retry");
                            dateInput = Console.ReadLine();
                        }
                        UserData.SetUserActiveTo(username, dt);
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        StreamReader stream_reader = new StreamReader("log.txt");
                        StringBuilder log = new StringBuilder(stream_reader.ReadToEnd());
                        Console.WriteLine(Convert.ToString(log));
                        stream_reader.Close();
                        break;
                    }
                case 5:
                    {
                        StringBuilder stringBuilder = new StringBuilder();

                        Console.WriteLine("Enter search: ");
                        string filter = Console.ReadLine();

                        foreach (string log in Logger.GetCurrentSessionActivities(filter))
                        {
                            stringBuilder.AppendLine(log);
                        }

                        Console.WriteLine(stringBuilder);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Въвели сте невалидна стойност!");
                        break;
                    }
            }
            Console.WriteLine("Натиснете произволен бутон за да продължите...");
            Console.ReadLine();

            Console.Clear();
            Administrator();

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Enter username: ");
            string user_name = Console.ReadLine();
            Console.Write("Enter user password: ");
            string pwd = Console.ReadLine();

            LoginValidation loginValidation = new LoginValidation(user_name, pwd, printErrorMessage);
            User user = null;

            //user.Username = "admin";
            //user.Password = "$trongPwd";
            //user.FakNum = "121218111";
            //user.Role = UserRoles.ADMIN;

            if (loginValidation.ValidateUserInput(ref user))
            {
                if (user != null)
                {
                    Console.WriteLine("Username: " + user.Username);
                    Console.WriteLine("Password: " + user.Password);
                    Console.WriteLine("Faculty number: " + user.FakNum);
                    Console.Write("Current user role: ");

                    switch (LoginValidation.currentUserRole)
                    {
                        case UserRoles.ANONYMOUS:
                            Console.WriteLine("Анинимен");
                            break;
                        case UserRoles.ADMIN:
                            Console.WriteLine("Администратор");
                            break;
                        case UserRoles.INSPECTOR:
                            Console.WriteLine("Инспектор");
                            break;
                        case UserRoles.PROFESSOR:
                            Console.WriteLine("Професор");
                            break;
                        case UserRoles.STUDENT:
                            Console.WriteLine("Студент");
                            break;
                        default:
                            Console.WriteLine("Непозната роля!");
                            break;
                    }

                    Administrator();
                }
            }

            void printErrorMessage(string errorMessage)
            {
                Console.WriteLine(errorMessage);
            }
        }
    }
}
