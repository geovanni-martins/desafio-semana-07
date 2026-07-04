string user = "admin", senha = "123456";

string userDigitado, senhaDigitada;
do {
   Console.WriteLine("Digite o usuário");
   userDigitado = Console.ReadLine();
   
   Console.WriteLine("Digite a senha");
   senhaDigitada = Console.ReadLine();
   
   if (userDigitado == user && senhaDigitada == senha) {
      Console.WriteLine("Usuário ou senha inválida");
   }
   
} while (userDigitado != user && senhaDigitada != senha);

Console.WriteLine("Aprovado");
