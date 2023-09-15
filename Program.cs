Console.WriteLine("Digite um numero inteiro");
int numero, centena, dezena, unidade;
numero = Convert.ToInt32(Console.ReadLine()!);
centena = numero / 100;
int restoum;
restoum = numero % 100;
dezena = restoum / 10;
int restodois;
restodois = restoum % 10;
unidade = restodois;

Console.Clear();
Console.WriteLine("");
Console.WriteLine($"O número {numero} possui:");
Console.WriteLine($"    {centena} centena(s)");
Console.WriteLine($"    {dezena} dezena(s)");
Console.WriteLine($"    {unidade} unidade(s)");
Console.WriteLine("");


