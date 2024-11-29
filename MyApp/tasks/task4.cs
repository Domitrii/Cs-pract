public class Task4 : ITask
{
    public void Execute()
    {
        Console.WriteLine("Завдання 4:");
        int[] array = { -8, 12, 3, -15, 7, 10, -6, 5, 20, -4, 9, 14, -13 };
        int m = 5;
        int myIndex = 6;
        int arrLength = 10 + myIndex;

        if (array.Length != arrLength)
        {
            Console.WriteLine($"Довжина масиву має бути {arrLength}, але отримано {array.Length}.");
            return;
        }

        int[] filteredArray = Array.FindAll(array, element => Math.Abs(element) > m);

        Console.WriteLine($"Задане число M: {m}");
        Console.WriteLine("Масив X: " + string.Join(", ", array));
        Console.WriteLine("Новий масив Y: " + string.Join(", ", filteredArray));
        Console.WriteLine();
    }
}