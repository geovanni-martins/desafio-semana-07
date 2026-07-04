void atenderPrimeiro(Queue<String> pessoas) {
    if (pessoas.Count > 0) {
        Console.WriteLine($"Atendendo {pessoas.Peek()}, a fila atualmente tem {pessoas.Count} pessoas");
        pessoas.Dequeue();
        Console.WriteLine($"Próximo: {pessoas.Peek()}, a fila atualmente tem {pessoas.Count} pessoas");
    }    
}

Queue<string> fila = new Queue<string>();

fila.Enqueue("Maria");
fila.Enqueue("João");
fila.Enqueue("Pedro");

atenderPrimeiro(fila);