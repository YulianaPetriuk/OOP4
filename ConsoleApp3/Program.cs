class Program
{
    static void Main()
    {
        // Задана квадратна матриця
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Початкова матриця:");
        PrintMatrix(matrix);

        // Обертання матриці
        RotateMatrixCounterClockwise(matrix);

        Console.WriteLine("Матриця після обертання на 90 градусів проти годинникової стрілки:");
        PrintMatrix(matrix);
    }

    static void RotateMatrixCounterClockwise(int[,] matrix)
    {
        int n = matrix.GetLength(0); // Розмірність квадратної матриці

        // Обертаємо матрицю
        for (int layer = 0; layer < n / 2; layer++)
        {
            int first = layer;
            int last = n - layer - 1;

            for (int i = first; i < last; i++)
            {
                int offset = i - first;

                // Зберігаємо верхній елемент
                int top = matrix[first, i];

                // Лівий елемент стає верхнім
                matrix[first, i] = matrix[last - offset, first];

                // Нижній елемент стає лівим
                matrix[last - offset, first] = matrix[last, last - offset];

                // Правий елемент стає нижнім
                matrix[last, last - offset] = matrix[i, last];

                // Верхній елемент стає правим
                matrix[i, last] = top;
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0); // Розмірність квадратної матриці
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}