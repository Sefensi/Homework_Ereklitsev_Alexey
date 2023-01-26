//Задача 13
/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/
Console.WriteLine("Введите число");
string number = Console.ReadLine();
if(number.Length < 3)
{
    Console.WriteLine("Число двузначное");
}
else
{
    char third_n = number[2];
    Console.WriteLine(third_n);
}
