using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Helpers
{
    public class Validate : IValidate
    {
        /// <summary>
        /// Method to handle password validation
        /// </summary>
        public bool PasswordChecker(string password)
        {
            string passwordRegex = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,}$";
            return RegularExpCheck(passwordRegex, password);
        }

        /// <summary>
        /// Method to handle Email validation
        /// </summary>
        public bool EmailChecker(string email)
        {
            string emailRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return RegularExpCheck(emailRegex, email);
        }

        /// <summary>
        /// Method to handle name validation
        /// </summary>
        public bool NameChecker(string name)
        {
            string nameRegex = @"^[A-Z][a-z]{2,}";
            return RegularExpCheck(nameRegex, name);
        }

        /// <summary>
        /// Method to handle phone validation
        /// </summary>
        public bool PhoneChecker(string phone)
        {
            string phoneRegex = @"^\+?[0-9]{3}-?[0-9]{6,12}$";
            return RegularExpCheck(phoneRegex, phone);
        }

        /// <summary>
        /// Method for regular experssions
        /// </summary>
        private bool RegularExpCheck(string code, string input)
        {
            Regex exp = new Regex(code);

            if (exp.IsMatch(input)) return true;
            return false;
        }
    }
}
