using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {
        public delegate void ActionOnError(string errorMsg);
        private ActionOnError actionOnError;
        static public UserRoles currentUserRole { get; private set; }        

        static public string Username { get; private set; }
        public string StatusMsg { get; private set; }
        private string Password;

        public LoginValidation(string user_name, string password)
        {
            Username = user_name;
            this.Password = password;
        }

        public LoginValidation(string user_name, string password, ActionOnError actionOnError)
        {
            Username = user_name;
            this.Password = password;
            this.actionOnError = actionOnError;            
        }

        public bool ValidateUserInput(ref User user)
        {
            //UserData.TestUser.Password = this.Password;
            //UserData.TestUser.Username = this.Username;

            //user = UserData.TestUser;

            if (string.IsNullOrEmpty(Username))
            {
                this.StatusMsg = "Не е посочено потребителско име";
                actionOnError(this.StatusMsg);
                return false;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                this.StatusMsg = "Не е посочена парола";
                actionOnError(this.StatusMsg);
                return false;
            }

            if(Username.Length < 5)
            {
                this.StatusMsg = "Потребителското име трябва да съдържа поне 5 символа!";
                actionOnError(this.StatusMsg);
                return false;
            }

            if (this.Password.Length < 5)
            {
                this.StatusMsg = "Паролата трябва да съдържа поне 5 символа!";
                actionOnError(this.StatusMsg);
                return false;
            }

            User user_temp = UserData.IsUserPassCorrect(Username, this.Password);

            if(user_temp != null)
            {
                user = user_temp;
                currentUserRole = user_temp.Role;
                Logger.LogActivity(user.Username + " -> Успешен вход!");
                return true;
            }

            this.StatusMsg = "Няма намерен потребител с посочените данни!";
            actionOnError(this.StatusMsg);
            currentUserRole = UserRoles.ANONYMOUS;
            return false;
        }
    }
}
