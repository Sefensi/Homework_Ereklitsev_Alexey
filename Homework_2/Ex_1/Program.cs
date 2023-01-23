//Задача 10
/*Напишите программу, которая принимает на вход трехзначное число и 
на выходе показывает вторую цифру этого числа.*/

Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();
char second_n = number[1];
Console.WriteLine(second_n);
