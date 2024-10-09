class Program
{
    static void Main()
    {
        // Заданий масив цілих чисел
        int[] numbers = { -5, 3, -2, 4, -1, 7, -6 };

        // Виклик методу для обчислення добутку від’ємних чисел
        int product = ProductOfNegativeNumbers(numbers);

        // Виведення результату
        Console.WriteLine("Добуток всіх від’ємних елементів у масиві: " + product);
    }

    static int ProductOfNegativeNumbers(int[] numbers)
    {
        int product = 1; // Ініціалізуємо добуток
        bool hasNegative = false; // Флаг для перевірки, чи є від’ємні числа

        // Перебір масиву для обчислення добутку від’ємних чисел
        foreach (int number in numbers)
        {
            if (number < 0) // Перевірка на від’ємність
            {
                product *= number;
                hasNegative = true; // Встановлюємо флаг, якщо знайдено від’ємне число
            }
        }

        // Якщо від’ємні числа не знайдено, повертаємо 0 або можна повернути інше значення за бажанням
        return hasNegative ? product : 0;
    }
}