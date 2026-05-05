using ContaCorrente.ConsoleApp.Entidades;

Conta conta1 = new Conta();
conta1.id = 1;
conta1.saldo = 1500;
conta1.titular = "Leandro";
conta1.limiteDebito = 700;

Conta conta2 = new Conta();
conta2.id = 2;
conta2.saldo = 6000;
conta2.titular = "Rech";
conta2.limiteDebito = 3000;

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"Conta Corrente");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("Seja Bem-Vindo, " + conta1.titular);
    Console.WriteLine();
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("1 - Saque");
    Console.WriteLine("2 - Depósito");
    Console.WriteLine("3 - Transferência");
    Console.WriteLine("4 - Consulta de Saldo");
    Console.WriteLine("S - Sair");
    Console.WriteLine("---------------------------------------------");
    Console.Write("> ");
    string? opcaoMenu = Console.ReadLine();
    Console.WriteLine("---------------------------------------------");

    if (opcaoMenu?.ToUpper() == "S")
        break;

    if (opcaoMenu == "1")
    {
        Console.Write("Digite o Valor do Saque: R$ ");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        conta1.Sacar(valorSaque);
    }
    else if (opcaoMenu == "2")
    {
        Console.Write("Digite o Valor do Depósito: R$ ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        conta1.Depositar(valorDeposito);
    }
    else if (opcaoMenu == "3")
    {
        Console.Write("Digite o Valor da Transferência: R$ ");
        decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

        conta1.Transferir(valorTransferencia, conta2);

        // Simulando a transferência para outra conta
        Console.WriteLine($"O Valor de R$ {valorTransferencia} foi Transferido da Conta {conta1.titular} para a Conta {conta2.titular}.");
        Console.ReadLine();
    }
    else if (opcaoMenu == "4")
    {
        conta1.ConsultarSaldo();
    }
}