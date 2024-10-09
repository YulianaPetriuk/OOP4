class Program
{
    static void Main()
    {
        // Заданий масив цілих чисел
        int[] numbers = { -5, 3, 12, -7, 0, 9, -1, 6 };

        // Виклик методу для знаходження суми додатних чисел
        int sum = SumOfPositiveNumbers(numbers);

        // Виведення результату
        Console.WriteLine("Сума всіх додатних елементів у масиві: " + sum);
    }

    static int SumOfPositiveNumbers(int[] numbers)
    {
        int sum = 0;

        // Перебір масиву і обчислення суми додатних чисел
        foreach (int number in numbers)
        {
            if (number > 0) // Перевірка на додатність
            {
                sum += number;
            }
        }

        return sum; // Повернення суми
    }
}