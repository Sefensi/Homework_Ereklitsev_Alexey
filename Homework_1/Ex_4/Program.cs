//Задача 8 
/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.*/

Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
string otvet = "";
for(int i=1; i < n + 1; i++)
{
    if(i % 2 == 0)
    {
        otvet += $" {Convert.ToString(i)}";
    }
}
Console.WriteLine(otvet);