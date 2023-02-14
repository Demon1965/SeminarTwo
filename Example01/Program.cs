
int number=new Random().Next(10,100);
Console.WriteLine($"Your Random Number: {number}");

int digit1=number/10;
int digit2=number%10;

if (digit1>digit2)
{
    Console.Write($"Maximum digit of number: {digit1}");
}
else if(digit2>digit1)
{
    Console.WriteLine($"Maximum digit of number: {digit2}");
}
else
{
    Console.WriteLine($"The digits are equally");
}