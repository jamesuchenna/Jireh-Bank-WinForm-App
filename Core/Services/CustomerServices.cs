using Core.Interface;
using DataAccess.DataStore;
using Domain.Models;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly IAuthentification _authentification;
        public CustomerServices(IAuthentification authentification)
        {
            _authentification = authentification;
        }

        /// <summary>
        /// Method to handle customer's registration
        /// </summary>
        public void RegisterUser(string firstName, string lastName, string email, string password, string phoneNumber)
        {
                Customer.IdCount++;
                Customer customer = new Customer()
                {
                    Id = Customer.IdCount,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Password = password,
                    PhoneNumber = phoneNumber,
                };

                Data.Customer.Add(customer);
            _authentification.CustomerLogin(email, password);
           }
    }
 }

