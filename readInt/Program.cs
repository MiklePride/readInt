class program
{
    static void Main(string[] args)
    {
        int number = 0;

        number = GetInt(ref number);

    }

    static int GetInt(ref int nubmer)
    {
        bool isExit = false;

        while (isExit == false)
        {
            Console.WriteLine("Введите Число:");

            int returnedNumber;
            string userInput = Console.ReadLine();
            bool successfulConversion = int.TryParse(userInput, out returnedNumber);

            if (successfulConversion)
            {
                Console.WriteLine("Конвертация прошла успешно! Записано число:" + returnedNumber);
                isExit = true;
            }
            else
            {
                Console.WriteLine("Неверные данные, попробуйте снова!");
            }

            return returnedNumber;
        }
    }
}