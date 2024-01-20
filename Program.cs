using System;
using System.Runtime.Remoting.Messaging;

class Program
{
    static void Main()
    {
        string Usuario = "Alex";
        string Senha = "Dev";

        Console.WriteLine("Por favor, realize o login.");

        Console.WriteLine("Usuário:");
        string usuarioDigitado = Console.ReadLine();

        Console.WriteLine("Senha:");
        string senhaDigitada = Console.ReadLine();

        if (ValidarLogin(usuarioDigitado, senhaDigitada, Usuario, Senha))
        {
            Console.WriteLine("Login bem-sucedido!");
        }
        else
        {
            Console.WriteLine("Usuário ou senha incorretos. Tente novamente.");
        }

        Console.ReadLine();
    }

    static bool ValidarLogin(string usuarioDigitado, string senhaDigitada, string Usuario, string Senha)
    {
        return usuarioDigitado == Usuario && senhaDigitada == Senha;
    }
    
}
