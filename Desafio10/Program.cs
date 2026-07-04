// Cenário
//     Você está desenvolvendo um sistema interno para uma empresa.
//     Cada usuário possui um cargo:
// Admin
//     Gerente
// Funcionário
//     Cada cargo possui permissões diferentes.
//     Tarefa
//     Receber o cargo e mostrar a permissão correspondente usando switch.

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