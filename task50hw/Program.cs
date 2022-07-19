// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
System.Console.WriteLine("Введите количество строк m двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов n двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Вы ввели размерность массива {m}x{n}");
Console.WriteLine($"Двумерный массив заполненный случайным образом будет выгдядеть:");
System.Console.WriteLine($"введите номер строки для поиска элемента в массиве начиная с 0");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"введите номер столбца для поиска элемента в массиве начиная с 0");
int y = Convert.ToInt32(Console.ReadLine());

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
            //int a = Math.Round(array[i, j],2);
            System.Console.Write($"{array[i, j], 5} ");
            //(Math.Round(array[i, j], 2)
        }
        System.Console.WriteLine();
    }
}
// void FindNumberInArray (int[,] array)
// {
//     int searchnumber = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//         if (array[i, j] == find)
//         {
//            System.Console.WriteLine($"число {find} есть в массиве");
//            System.Console.WriteLine($"номер строки {i},номер столбца {j}");
//         searchnumber++;
//         }
//         }
//     }
//     if (searchnumber ==0)
//     {
//         System.Console.WriteLine($"числа {find} в массиве нет"); 
//     }
// }

void FindNumberInArrayOfPosition (int[,] array)
{
    int searchnumber = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        if (i==x && j==y)
        {
           System.Console.WriteLine($"число по указанным координатам найдено: {array[i,j]} ");
           break;
        }
        }
    }
    if (x>m || y>n)
    {
       System.Console.WriteLine($"числа по строке {x} и столбцу {y} в массиве нет");   
    }
   
}


FillArrayToNumbers(arrayrandom);
PrintArrayToNumbers(arrayrandom);
//FindNumberInArray(arrayrandom);
FindNumberInArrayOfPosition(arrayrandom);