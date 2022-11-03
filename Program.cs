System.Console.WriteLine("Enter a number of week day from 1 to 7, and you will know is it a day off: ");
int dayWeek = int.Parse(Console.ReadLine());

switch (dayWeek)
{
    case 1:
    System.Console.WriteLine("No");
    break;
    case 2:
    System.Console.WriteLine("No");
    break;
    case 3:
    System.Console.WriteLine("No");
    break;
    case 4:
    System.Console.WriteLine("No");
    break;
    case 5:
    System.Console.WriteLine("No");
    break;
    case 6:
    System.Console.WriteLine("Yes");
    break;
    case 7:
    System.Console.WriteLine("Yes");
    break;
    default:
    System.Console.WriteLine("Enter number of week day from 1 to 7");
    break;
}



