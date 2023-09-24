int n;
bool isInt = false;
do
{
    Console.WriteLine("Введіть ціле число: ");
    string input = Console.ReadLine();
    if (input == "")
    {
        Console.WriteLine("Ви не ввели число!");
    }
    else
    {
        try
        {
            n = int.Parse(input);
            Console.WriteLine($"Ви ввели ціле число {n}.");
            isInt = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("Ви ввели не ціле число! Спробуйте ще раз.");
        }
    }
} while (!isInt);
