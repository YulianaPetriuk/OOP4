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

        // Вказуємо стовпець для обчислення добутку (наприклад, 1 для другого стовпця)
        int columnIndex = 1;

        // Виклик методу для обчислення добутку елементів вказаного стовпця
        int product = ProductOfColumn(matrix, columnIndex);

        // Виведення результату
        Console.WriteLine("Добуток елементів стовпця " + columnIndex + ": " + product);
    }

    static int ProductOfColumn(int[,] matrix, int columnIndex)
    {
        int product = 1; // Ініціалізуємо добуток
        bool hasElements = false; // Флаг для перевірки, чи є елементи в стовпці

        // Перебір рядків матриці для обчислення добутку вказаного стовпця
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (columnIndex >= 0 && columnIndex < matrix.GetLength(1)) // Перевірка коректності індексу
            {
                product *= matrix[i, columnIndex]; // Додаємо елемент до добутку
                hasElements = true; // Встановлюємо флаг
            }
            else
            {
                return 0; // Якщо індекс стовпця некоректний, повертаємо 0
            }
        }

        return hasElements ? product : 0; // Повертаємо добуток або 0, якщо стовпець порожній
    }
}