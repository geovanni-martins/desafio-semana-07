Console.WriteLine("Qual seu cargo (Admin, Gerente, Funcionário): ");
string cargo = Console.ReadLine();

switch (cargo.ToLower())
{
    case "admin":
        Console.WriteLine("Permissão: Acesso total ao sistema.");
        break;

    case "gerente":
        Console.WriteLine("Permissão: Gerenciar equipes e visualizar relatórios.");
        break;

    case "funcionário":
        Console.WriteLine("Permissão: Acesso às funções básicas do sistema.");
        break;

    default:
        Console.WriteLine("Cargo inválido.");
        break;
}