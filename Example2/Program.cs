Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA>numberB)
{
    Console.Write("Max = ");
    Console.WriteLine(numberA);
    Console.Write("Min = ");
    Console.WriteLine(numberB);
}
else
{
    Console.Write("Max = ");
    Console.WriteLine(numberB);
    Console.Write("Min = ");
    Console.WriteLine(numberA);
}



