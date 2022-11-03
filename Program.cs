System.Console.WriteLine("Enter three-digit number: ");
int num = int.Parse(Console.ReadLine());
int numSecond = 0;

if (num > 99 && num < 1000)
{
    numSecond = num / 10;
    numSecond = numSecond % 10;
    System.Console.WriteLine(numSecond);
}
else
{
    System.Console.WriteLine("Enter three-digit number");
}