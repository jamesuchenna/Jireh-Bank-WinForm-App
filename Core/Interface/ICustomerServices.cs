namespace Core.Interface
{
    public interface ICustomerServices
    {
        void RegisterUser(string firstName, string lastName, string email, string password, string phoneNumber);
    }
}