namespace Helpers
{
    public interface IValidate
    {
        bool PasswordChecker(string password);
        bool EmailChecker(string email);
        bool NameChecker(string name);
        bool PhoneChecker(string phone);
        //bool RegularExpCheck(string code, string input);

    }
}