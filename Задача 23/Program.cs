﻿/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Clear();
Console.Write("Введите число N: ");
int N = new int[N];
// n=5
// 0 1 2 3 4 
// 0 0 0 0 0
//1 2 3 4 5
//1 4 9 16 25
 for (int i = 1; i <= N; i++)
    result[i - 1] = i * i;
   
    for (int i = 0; i < N; i++)
Console.Write($"{result[i]} ");
    for (int i = 0; i < N; i++)
Console.Write($"{result[i]} ");