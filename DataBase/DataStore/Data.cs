using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataStore
{
    /// <summary>
    /// This method Serves as the data base
    /// </summary>
    public class Data
    {
        public static Customer currentUser { get; set; }
        public static List<Customer> Customer { get; set; } = new List<Customer>();
        public static List<Account> Accounts { get; set; } = new List<Account>();
        public static List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
