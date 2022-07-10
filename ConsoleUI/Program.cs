// See https://aka.ms/new-console-template for more information

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            var user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);
            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }
            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();

        }

    }
}
