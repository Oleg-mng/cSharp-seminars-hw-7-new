// Задача 47. Задайте двумерный массив размером m×n, заполненный
//случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
System.Console.WriteLine("Введите количество строк m двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов n двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Вы ввели размерность массива {m}x{n}");
Console.WriteLine($"Двумерный массив заполненный случайным образом будет выгдядеть:");
double[,] arrayrandom = new double[m, n];
Random r = new Random();
void FillArrayToDoubleNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //array[i, j] = new Random().NextDouble()*100 - 50;
            array[i, j] = r.NextDouble()*100 - 50;
        }
    }

}
void PrintArrayToDoubleNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double a = Math.Round(array[i, j],2);
            System.Console.Write($"{a, 7} ");
            //(Math.Round(array[i, j], 2)
        }
        System.Console.WriteLine();
    }

}
FillArrayToDoubleNumbers(arrayrandom);
PrintArrayToDoubleNumbers(arrayrandom);