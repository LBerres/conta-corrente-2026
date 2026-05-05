using System;

namespace ContaCorrente.ConsoleApp.Entidades;

// Centraliza Atributos e Métodos em Comum
public class Conta
{
    public int id;
    public decimal saldo;
    public decimal limiteDebito;

    public string? titular;

    public void Sacar(decimal valorSaque)
    {
        decimal limiteSaque = saldo + limiteDebito;

        if (valorSaque > limiteSaque)
        {
            Console.WriteLine("Não é possível efetuar o saque. O limite foi ultrapassado.");
            Console.ReadLine();
            return;
        }

        saldo -= valorSaque;

        Console.WriteLine($"O saque de R$ {valorSaque} foi efetuado com sucesso.");
        Console.ReadLine();
    }

    public void Depositar(decimal valorDeposito)
    {
        saldo += valorDeposito;

        Console.WriteLine($"O depósito de R$ {valorDeposito} foi efetuado com sucesso.");
        Console.ReadLine();
    }

    public void Transferir(decimal valorTransferencia, Conta contaDestino)
    {
        decimal limiteTransferencia = saldo + limiteDebito;

        if (valorTransferencia > limiteTransferencia)
        {
            Console.WriteLine("Não é possível efetuar a transferência. O limite foi ultrapassado.");
            Console.ReadLine();
            return;
        }

        this.Sacar (valorTransferencia);
        contaDestino.Depositar (valorTransferencia);
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"O saldo da conta de {titular} é de: R$ {saldo}");
        Console.ReadLine();
    }
}
