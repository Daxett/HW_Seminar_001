﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка.).

Console.WriteLine ("ВВедите число, чтобы узнать четное оно или нет ");
if (Convert.ToInt32(Console.ReadLine()) % 2 == 0)
    Console.WriteLine("Четное");
else
    Console.WriteLine("Не четное");