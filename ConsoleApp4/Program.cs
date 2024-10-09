class Program
{
    static void Main()
    {
        // Заданий масив цілих чисел
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Виклик методу для обчислення середнього арифметичного
        double average = CalculateAverage(numbers);

        // Виведення результату
        Console.WriteLine("Середнє арифметичне: " + average);
    }

    static double CalculateAverage(int[] numbers)
    {
        // Перевірка, чи масив не порожній
        if (numbers.Length == 0)
        {
            throw new ArgumentException("Масив не може бути порожнім.");
        }

        // Обчислення суми елементів масиву
        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Обчислення середнього арифметичного
        return sum / numbers.Length;
    }
}