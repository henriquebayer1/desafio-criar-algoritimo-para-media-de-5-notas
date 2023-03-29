Console.WriteLine($"Digite o nome do aluno");
string aluno = Console.ReadLine();


Console.WriteLine($"Digite as 5 notas do aluno:");

Console.WriteLine($"Nota 1 -");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Nota 2 -");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Nota 3 -");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine($"Nota 4 -");
int nota4 = int.Parse(Console.ReadLine());

Console.WriteLine($"Nota 5 -");
int nota5 = int.Parse(Console.ReadLine());

float media = ((nota1 + nota2 + nota3 + nota4 + nota5) / 5);

Console.WriteLine($"A media do {aluno} e de {media}");



