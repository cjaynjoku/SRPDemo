// See https://aka.ms/new-console-template for more information

namespace ConsoleUI
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 2) + user.LastName}");
        }
    }
}
