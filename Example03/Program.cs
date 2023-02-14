
Console.Write("Print first number:   ");
int number1=Convert.ToInt32(Console.ReadLine());
Console.Write("Print second number:   ");
int number2=Convert.ToInt32(Console.ReadLine());

int num=number1%number2;

if (num==0)
{
    Console.Write($"Both numbers are multiply");
}
else
{
    Console.Write("Both numbers aren't multiply");
}