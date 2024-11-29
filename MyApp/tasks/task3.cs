public class Task3 : ITask
{
    public void Execute()
    {
        Console.WriteLine("Завдання 3:");
        int[] array = { 14, 2, 9, 18, 5, 7, 11, 3, 21, 4, 10, 13, 17 };
        int groupNumber = 6; 
        int arrayLength = 10 + groupNumber;

        if (array.Length != arrayLength)
        {
            Console.WriteLine($"Довжина масиву має бути {arrayLength}, але отримано {array.Length}.");
            return;
        }

        int min = array[0];
        int max = array[0];

        foreach (int number in array)
        {
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine("Масив: " + string.Join(", ", array));
        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");
        Console.WriteLine();
    }
}