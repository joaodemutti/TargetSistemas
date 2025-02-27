
using Newtonsoft.Json;

string file = File.ReadAllText("dados.json");
IEnumerable<dynamic> json = JsonConvert.DeserializeObject<IEnumerable<dynamic>>(file);
var diasUteis = json.Where(d => d.valor > 0);

var menor = diasUteis.Min(d=>d.valor);

var maior = diasUteis.Max(d => d.valor);

Console.WriteLine($"Menor Faturamento:\n{menor}\n");
Console.WriteLine($"Maior Faturamento:\n{maior}\n");

Console.WriteLine("Dias com faturamento maior que a média mensal:");

double media = diasUteis.Average(d => d.valor);

var total = diasUteis.Where(d => d.valor > media).Count();

Console.WriteLine($"{total}\n");  

Console.ReadLine();

