
Console.Write("Print first number:  ");
int number1=Convert.ToInt32(Console.ReadLine());
Console.Write("Print second number:  ");
int number2=Convert.ToInt32(Console.ReadLine());

if (number1*number1==number2)
{
    Console.WriteLine($"YES, it so!");
}
else
{ 
    Console.WriteLine($"No, sorry");
}
