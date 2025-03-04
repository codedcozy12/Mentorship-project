
Console.WriteLine("Enter a number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter another number");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter another number");
int c = int.Parse(Console.ReadLine());
Console.WriteLine(ThreeSumming(a , b , c));
static int ThreeSumming(int a, int b, int c)
{
    return a + b + c;
}
