﻿// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите элементы; ");
int[]arr = Array.ConvertAll(ReadLine().Split(),int. Parse);

int count = 0;
for(int i = 0; i < arr.Length;i++)
{
    if(arr[i]>0)
    {
        count++;
    }
}
WriteLine ($"Количество элементов больше 0: {count}");
