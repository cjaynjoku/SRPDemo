namespace ConsoleUI
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("welcome to my application");
        }
        public static void EndApplication()
        {
            Console.WriteLine("Press Enter to close...");
            Console.ReadLine();
        }
        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid {fieldName}.");
        }

    }
}
