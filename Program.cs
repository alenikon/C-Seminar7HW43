// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
using System;

class Program {
  public static void Main (string[] args) {

Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[5, 5];
InputArray(array);
PrintArray(array);

if (rows < array.GetLength(0)+1 && colums < array.GetLength(1)+1) Console.WriteLine(array[rows-1, colums-1]);
else Console.WriteLine($"Элемент в строке №{rows} и столбце №{colums} -> отсутствует");

void InputArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99)/ 10.0;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}
  }
}
