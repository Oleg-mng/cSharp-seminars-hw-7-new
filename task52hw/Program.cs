// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
System.Console.WriteLine("Введите количество строк m двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов n двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Вы ввели размерность массива {m}x{n}");
Console.WriteLine($"Двумерный массив заполненный случайным образом будет выгдядеть:");

int[,] arrayrandom = new int[m, n];
Random r = new Random();

void FillArrayToNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = r.Next(0, 12);
        }
    }
}
void PrintArrayToNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //int a = Math.Round(array[i, i],2);
            System.Console.Write($"{array[i, j],5} ");
            //(Math.Round(array[i, i], 2)
        }
        System.Console.WriteLine();
    }
}
void SearchAverageOnColumn(int[,] array)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];

        }
        average = sum / array.GetLength(1);
        System.Console.WriteLine($"среднее арифметическое по столбцу {j} равняется {average}");
    }
}
FillArrayToNumbers(arrayrandom);
PrintArrayToNumbers(arrayrandom);
SearchAverageOnColumn(arrayrandom);