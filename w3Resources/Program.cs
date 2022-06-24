Console.WriteLine("input");
int n = int.Parse(Console.ReadLine());
bool v = true;

if (n <= 100 && n % 10 == 0)
{
    Console.WriteLine(v);
}
else if (n > 100 && n <= 200)
{
    Console.WriteLine(v);
}
else
{
    v = false;
    Console.WriteLine(v);
}
