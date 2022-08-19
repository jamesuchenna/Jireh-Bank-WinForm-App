using Domain.Enums;

namespace Domain.Models
{
    public interface IAccount
    {
        string AccountName { get; set; }
        string AccountNumber { get; set; }
        double Balance { get; set; }
        int CustomerId { get; set; }
        int Id { get; set; }
        bool IsActive { get; set; }
        AccountType Type { get; set; }
    }
}