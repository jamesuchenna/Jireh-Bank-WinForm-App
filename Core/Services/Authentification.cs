using DataAccess.DataStore;
using Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class Authentification : IAuthentification
    {
        /// <summary>
        /// Method to authenticate customer's login
        /// </summary>
        public bool CustomerLogin(string userEmail, string userPassword)
        {
            foreach (var user in Data.Customer)
            {
                if (user.Email == userEmail && user.Password == userPassword)
                {
                    Data.currentUser = user;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method responsible for logging out
        /// </summary>
        public void CustomerLogOut()
        {
            Data.currentUser = null;
        }
    }
}
