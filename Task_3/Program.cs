// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите первое число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

if (paramInt % 2 == 1)
{
    Console.WriteLine($"{paramInt} - число нечетное ");
}

else
{
    Console.WriteLine($"{paramInt} - число четное ");
}

