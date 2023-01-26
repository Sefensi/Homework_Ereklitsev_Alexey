//Задача 19
/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/
// 1234321
Console.WriteLine("Введите число");
string number = Console.ReadLine();
string palindrom(string number)
{
    for (int i = 0; i < (number.Length) / 2; i++)
    {
        char first = number[i];
        char second = number[number.Length - i - 1];
        if (first != second)
        {
            return "Число не является палиндромом";
        }
    }
    return "число явдяется палиндромом";
}

Console.WriteLine(palindrom(number));