class Program
{
    static void Main()
    {
        // Створюємо двовимірний масив (матрицю)
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Виклик методу для обчислення суми елементів по головній діагоналі
        int sum = SumOfMainDiagonal(matrix);

        // Виведення результату
        Console.WriteLine("Сума елементів по головній діагоналі: " + sum);
    }

    static int SumOfMainDiagonal(int[,] matrix)
    {
        int sum = 0;
        int size = Math.Min(matrix.GetLength(0), matrix.GetLength(1)); // Знаходимо розмір діагоналі

        // Обчислюємо суму елементів по головній діагоналі
        for (int i = 0; i < size; i++)
        {
            sum += matrix[i, i]; // Додаємо елемент по головній діагоналі
        }

        return sum; // Повертаємо суму
    }
}