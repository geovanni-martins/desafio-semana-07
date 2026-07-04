string name = Console.ReadLine();
string n1Str = Console.ReadLine();
string n2Str = Console.ReadLine();

int n1Int = Convert.ToInt32(n1Str);
int n2Int = Convert.ToInt32(n2Str);

float media = (n1Int + n2Int) / 2;

Console.WriteLine($"Sua média é {media}");

if (media >= 7) {
    Console.WriteLine("Aprovado");
} else if (media >= 5 && media < 7) {
    Console.WriteLine("Recuperação");
} else {
    Console.WriteLine("Reprovado");
}

