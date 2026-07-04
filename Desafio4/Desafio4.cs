Stack<string> historico = new Stack<string>();

historico.Push("Home");
historico.Push("Produtos");
historico.Push("Carrinho");

Console.WriteLine($"Página atual: {historico.Peek()}");

while (historico.Count > 1) {
    Console.WriteLine($"Voltando da página {historico.Pop()}...");
    Console.WriteLine($"Agora você está em: {historico.Peek()}");
}

Console.WriteLine("Você já está na página Home");