// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();

int[,] matrix = new int[, ]{{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
float val = 0;
Console.WriteLine("Среднее арифметическое каждого столбца:");

for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j= 0; j < matrix.GetLength(0); j++)
    {
        val = val + matrix[j, i];
    }
    Console.Write($"{val / 3}; ");
    val = 0;
}