//Задача 13
/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*/
Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 6)
{
    Console.WriteLine("Сегодня не выходной((");
}
else
{
    Console.WriteLine("Сегодня выходной");
}