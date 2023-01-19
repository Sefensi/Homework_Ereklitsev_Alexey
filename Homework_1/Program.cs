//Задача 2
Console.WriteLine("Введите a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > b)
{
    max = a;
}
else 
{
    max = b;
}
Console.Write("max = ");
Console.Write(max);
