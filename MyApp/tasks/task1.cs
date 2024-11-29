public class Task1 : ITask
{
    public void Execute()
    {
        Console.WriteLine("Завдання 1:");
        int[] numbers = { 17, 8, 5 };
        int fromNumb = 6; 
        int toNumb = 10 + fromNumb;

        Console.WriteLine($"Інтервал: [1, {toNumb}]");
        Console.WriteLine("Числа, входячі в інтервалу:");

        foreach (var number in numbers)
        {
            if (number >= 1 && number <= toNumb)
            {
                Console.WriteLine(number);
            }
        }
        Console.WriteLine();
    }
}