class Program
{
    static void Main()
    {
        // Заданий масив цілих чисел
        int[] numbers = { 4, 2, 7, 8, 2, 5, 2 };

        // Значення, індекс якого потрібно знайти
        int target = 2;

        // Виклик методу для пошуку найменшого індексу
        int index = FindFirstIndex(numbers, target);

        // Виведення результату
        if (index != -1)
        {
            Console.WriteLine("Найменший індекс елемента " + target + ": " + index);
        }
        else
        {
            Console.WriteLine("Елемент " + target + " не знайдено в масиві.");
        }
    }

    static int FindFirstIndex(int[] numbers, int target)
    {
        // Перебір масиву для знаходження найменшого індексу
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                return i; // Повертає перший знайдений індекс
            }
        }

        return -1; // Якщо елемент не знайдено
    }
}