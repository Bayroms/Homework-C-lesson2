System.Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int result1 = num % 10;
    System.Console.WriteLine(result1);
}
if (num < 100)
{
    System.Console.WriteLine("There is no third digit");
}
if (num > 999)
{
    while (num > 1000)
    {
    num /= 10;
    }
    int result2 = num % 10;
    System.Console.WriteLine(result2);   
}

