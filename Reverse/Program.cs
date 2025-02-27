Console.WriteLine("Insira um texto:");

var str = Console.ReadLine();

string result = "";
foreach (char c in  str)
{
    result = c + result;
}

Console.WriteLine(result);

Console.ReadLine();