using System;

namespace ContaCorrente.ConsoleApp.Entidades;

// Centraliza Atributos e Métodos em Comum
public static class Conta
{
    public static int id = 1;
    public static decimal saldo = 1200;
    public static decimal limiteDebito = 800;

    public static void Sacar(decimal valorSaque)
    {
        decimal limiteSaque = Conta.saldo + Conta.limiteDebito;

        if (valorSaque > limiteSaque)
        {
            Console.WriteLine("Não é possível efetuar o saque. O limite foi ultrapassado.");
            Console.ReadLine();
            return;
        }

        Conta.saldo -= valorSaque;

        Console.WriteLine($"O saque de R$ {valorSaque} foi efetuado com sucesso.");
        Console.ReadLine();
    }

    public static void Depositar(decimal valorDeposito)
    {
        Conta.saldo += valorDeposito;

        Console.WriteLine($"O depósito de R$ {valorDeposito} foi efetuado com sucesso.");
        Console.ReadLine();
    }

    public static void ConsultarSaldo()
    {
        Console.WriteLine($"O saldo da conta é de: R$ {Conta.saldo}");
        Console.ReadLine();
    }
}
