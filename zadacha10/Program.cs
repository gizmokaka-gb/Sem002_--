﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
string num = Console.ReadLine();

int number = int.Parse (num); // если необходимо закрыть программу при вводе значения отличного от числа.

Console.WriteLine($"Вторая цифра числа {num} - это {num[1]}.");