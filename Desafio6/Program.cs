Dictionary<string, int> loja = new Dictionary<string, int>();

loja.Add("Mouse", 80);
loja.Add("Teclado", 120);
loja.Add("Monitor", 900);

Console.WriteLine("Escolha o produto que quer ver (Mouse, Teclado, Monitor)");
string escolhaUser = Console.ReadLine();

Console.WriteLine(loja[escolhaUser]);