using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Account : IAccount
    {
        public static int IdCount = 0;
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public AccountType Type { get; set; }
        public double Balance { get; set; }
        public int CustomerId { get; set; }
        public bool IsActive { get; set; }

    }
}
