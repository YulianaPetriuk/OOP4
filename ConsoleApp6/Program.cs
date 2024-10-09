class Program
{
    static void Main()
    {
        // Заданий масив цілих чисел
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Виклик методу для знаходження парних чисел
        FindEvenNumbers(numbers);
    }

    static void FindEvenNumbers(int[] numbers)
    {
        Console.WriteLine("Парні числа у масиві:");

        // Перебір масиву і виведення парних чисел
        foreach (int number in numbers)
        {
            if (number % 2 == 0) // Перевірка на парність
            {
                Console.WriteLine(number);
            }
        }
    }
}