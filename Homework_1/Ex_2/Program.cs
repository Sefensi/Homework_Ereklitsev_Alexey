//Задача 4
Console.WriteLine("Введите a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(a > b)
{
    if(a > c)
    {
        max = a; 
    }
    else
    {
        max = c;
    }
}
else if(b > c)
{
    max = b;
}
else
{
    max = c;
}
Console.WriteLine($"наибольшее из трех - {max}");