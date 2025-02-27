

IEnumerable<dynamic> faturamentos = new dynamic[] {
    new { estado = "RJ", valor =36678.66 },
    new { estado = "MG", valor = 29229.88 },
    new { estado = "ES", valor = 27165.48 },
    new { estado = "Outros", valor = 19849.53 }
};

double total = faturamentos.Sum(f => (double)f.valor);

Console.WriteLine($"Total: {total}\n");

foreach (var faturamento in faturamentos)
{
    var percentual = (faturamento.valor / total) * 100;

    Console.WriteLine($"{faturamento.estado}: {percentual:F2}%");
   
}

Console.ReadLine();

