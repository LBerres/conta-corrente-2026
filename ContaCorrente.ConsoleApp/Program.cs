int id = 1;
decimal saldo = 1200;
decimal limiteDebito = 800;

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"Conta Corrente");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("1 - Saque");
    Console.WriteLine("2 - Depósito");
    Console.WriteLine("3 - Consulta de Saldo");
    Console.WriteLine("S - Sair");
    Console.WriteLine("---------------------------------------------");
    Console.Write("> ");
    string? opcaoMenu = Console.ReadLine();
    Console.WriteLine("---------------------------------------------");

    if (opcaoMenu?.ToUpper() == "S")
        break;

    if (opcaoMenu == "1")
    {
        Console.Write("Digite o valor do saque: R$ ");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        decimal limiteSaque = saldo + limiteDebito;

        if (valorSaque > limiteSaque)
        {
            Console.WriteLine("Não é possível efetuar o saque. O limite foi ultrapassado.");
            Console.ReadLine();
            continue;
        }

        saldo -= valorSaque;

        Console.WriteLine($"O saque de R$ {valorSaque} foi efetuado com sucesso.");
        Console.ReadLine();
    }
    else if (opcaoMenu == "2")
    {
        Console.Write("Digite o valor do depósito: R$ ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        saldo += valorDeposito;

        Console.WriteLine($"O depósito de R$ {valorDeposito} foi efetuado com sucesso.");
        Console.ReadLine();
    }
    else if (opcaoMenu == "3")
    {
        Console.WriteLine($"O saldo da conta é de: R$ {saldo}");
        Console.ReadLine();
    }
}