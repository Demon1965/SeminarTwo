
int number=new Random().Next(99,1000);
Console.WriteLine($"Your Random Number: {number}");

int digit1=number/100;
int digit2=number%10;

Console.WriteLine($"Your new number: "+$"{digit1}"+$"{digit2}");
