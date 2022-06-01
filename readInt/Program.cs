class program
{
    static void Main(string[] args)
    {
        int number = 0;

        number = GetInt(number);
    }

    static int GetInt(int nubmer)
    {
        bool isExit = false;
        int returnedNumber = 0;

        while (isExit == false)
        {
            Console.WriteLine("Введите Число:");
            
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
        }
        return returnedNumber;
    }
}