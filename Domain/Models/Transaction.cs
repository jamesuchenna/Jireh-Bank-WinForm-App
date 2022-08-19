using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Transaction
    {
        public static int TransactionIdCount = 0;
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public double Balance { get; set; }
        public double Amount { get; set; }
        public AccountType AccountType { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
