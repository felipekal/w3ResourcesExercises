Console.Write("Input: ");
int n = int.Parse(Console.ReadLine());

int result = 0;

if (n < 51)
{
    n = 51 - n;
    Console.WriteLine(n);
}
else
{
    n = 3 * (51 - n);
    Console.WriteLine(n);
}
