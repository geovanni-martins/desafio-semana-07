string nomeProduto = Console.ReadLine();
string qtdProdutoStr = Console.ReadLine();

int qtdProdutoInt = Convert.ToInt32(qtdProdutoStr);

if (qtdProdutoInt < 5) {
    Console.WriteLine("Estoque Critico");
} else if (qtdProdutoInt > 5 && qtdProdutoInt <= 10) {
    Console.WriteLine("Estoque Baixo");
} else {
    Console.WriteLine("Estoque OK");
}