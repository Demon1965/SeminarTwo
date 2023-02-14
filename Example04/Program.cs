
Console.Write("Print number:   ");
int number=Convert.ToInt32(Console.ReadLine());

if (number%7==0 && number%23==0)
{
    Console.WriteLine($"Everything fine!");
}
else
{
    Console.WriteLine($"So terrible!");
}