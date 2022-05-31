class program
{
    static void Main(string[] args)
    {
        bool isExit = false;
        int number;
        Console.WriteLine("Введите любое число:");

        while (isExit == false)
        {
            string userInput = Console.ReadLine();
            number = ReturnNumber(userInput);
        }
    }

    static int ReturnNumber(string userInput)
    {
        int returnedNumber;
        bool success = int.TryParse(userInput, out returnedNumber);

        if (success)
        {
            Console.WriteLine(returnedNumber);
            return returnedNumber;
        }
        else
        {
            Console.WriteLine("Неверные данные!");
        }
    }
}