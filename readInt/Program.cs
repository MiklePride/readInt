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
            
            if (number != 0)
            {
                isExit = true;
            }
        }
    }

    static int ReturnNumber(string userInput)
    {
        int returnedNumber;
        bool success = int.TryParse(userInput, out returnedNumber);

        if (success)
        {
            Console.WriteLine("Конвертация прошла успешно! Записано число:" + returnedNumber);
        }
        else
        {
            Console.WriteLine("Неверные данные, попробуйте снова!");
        }
        return returnedNumber;
    }
}