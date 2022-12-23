Console.WriteLine("Введите  число N");
int number = Convert.ToInt32(Console.ReadLine());
if(number%2==0)
{
    while (number>0)
    {
        Console.Write(number);
        Console.Write(" ");
        number= number-2;   
    }
}
else
{
    number= number - 1;
    while (number>0)
    {
        Console.Write(number);
        Console.Write(" ");
        number= number-2;   
    }
}