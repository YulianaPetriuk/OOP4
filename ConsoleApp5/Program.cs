class Program
{
    static void Main()
    {
        // Заданий масив
        int[] numbers = { 1, 2, 3, 2, 1 };

        // Перевірка, чи є масив паліндромом
        bool isPalindrome = IsPalindrome(numbers);

        // Виведення результату
        if (isPalindrome)
        {
            Console.WriteLine("Масив є паліндромом.");
        }
        else
        {
            Console.WriteLine("Масив не є паліндромом.");
        }
    }

    static bool IsPalindrome(int[] numbers)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            if (numbers[left] != numbers[right])
            {
                return false; // Якщо елементи не співпадають, масив не є паліндромом
            }
            left++;
            right--;
        }

        return true; // Масив є паліндромом
    }
}