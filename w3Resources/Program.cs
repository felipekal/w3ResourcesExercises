Console.Write("Sentence: ");
string s = Console.ReadLine();
Console.Write("Index: ");
int n = int.Parse(Console.ReadLine());

string str = s.Remove(n, 1);
Console.WriteLine($"Removed the letter {s[n]} from the original sentence");
Console.WriteLine($"New word is {str}");
