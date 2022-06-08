// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
Console.Write("Введите первое число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

while (paramInt > 0)
if (paramInt % 2 == 1)
{
    paramInt = paramInt - 1;
}

else
{
    Console.Write($"{paramInt}  ");
    paramInt = paramInt - 1;
}




