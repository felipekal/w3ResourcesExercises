Console.WriteLine("Input: ");
int value1 = int.Parse(Console.ReadLine());
int value2 = int.Parse(Console.ReadLine());
int result = 0;
if(value1 != value2)
{
    result = value1 + value2;   
}
else
{
    result = 3 * (value1 + value2);
}
Console.WriteLine(result);
