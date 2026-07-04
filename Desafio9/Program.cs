Queue<string> chamados = new Queue<string>();

chamados.Enqueue("Impressora não funciona");
chamados.Enqueue("Computador lento");
chamados.Enqueue("Problema no e-mail");

Console.WriteLine("Chamados cadastrados:");

foreach (string chamado in chamados) {
    Console.WriteLine(chamado);
}

Console.WriteLine("Atendendo chamado...");
string atendido = chamados.Dequeue();

Console.WriteLine($"Chamado atendido: {atendido}");

Console.WriteLine("Chamados restantes:");
foreach (string chamado in chamados) {
    Console.WriteLine(chamado);
}