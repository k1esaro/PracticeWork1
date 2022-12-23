Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberС = Convert.ToInt32(Console.ReadLine());
int max = 0 ;
if(numberA>numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}
if (max>numberС)
{
    Console.Write("Max = ");
    Console.WriteLine(max);
}
else
{
    max = numberС;
    Console.Write("Max = ");
    Console.WriteLine(max);
}