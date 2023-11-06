Console.WriteLine("Введите размерность матрицы:");
bool isContinue = true;
bool isParseSuccess = int.TryParse(Console.ReadLine(), out int dimension);
if (isParseSuccess)
{
    while (isContinue)
    {
        int[,] numbers = new int[dimension, dimension];
        Console.WriteLine("Вводим элементы матрицы:");
        for (int i = 0; i < dimension; i++)
        {
            for (int j = 0; j < dimension; j++)
            {
                bool isInputInt = int.TryParse(Console.ReadLine(), out int inputNumber);
                if (isInputInt)
                {
                    numbers[i, j] = inputNumber;
                    Console.WriteLine($"Зачение по координате {i + 1} {j + 1} - {numbers[i, j]}");
                }
                else
                {
                    Console.WriteLine("Введено некорректное число");
                    j--;
                }
            }
        }
        Console.WriteLine("Сумма элементов побочной диагонали заданной матрицы:");
        int sumOfSideDiagonal = 0;
        for (int i = 0; i < dimension; i++)
        {
            sumOfSideDiagonal += numbers[i, dimension - 1 - i];
        }

        Console.WriteLine(sumOfSideDiagonal);
        Console.WriteLine("Сумма элементов, находящихся под побочной диагональю матрицы:");
        int sumUnderSideDiagonal = 0;
        for (int i = 0; i < dimension; i++)
        {
            for (int j = dimension - i; j < dimension; j++)
            {
                sumUnderSideDiagonal += numbers[i, j];
            }
        }
        Console.WriteLine(sumUnderSideDiagonal);
    }
    isContinue = false;
}