int valorCompra;

Console.WriteLine("Qual o valor da compra?");
valorCompra = Convert.ToInt32(Console.ReadLine());

if (valorCompra >= 300) {
    Console.WriteLine("Frete grátis");
} else if (valorCompra <= 299 && valorCompra >= 200) {
    Console.WriteLine("Frete R$ 15");
} else {
    Console.WriteLine("Frete R$ 30");
}

Console.WriteLine($"O valor total R${valorCompra}");