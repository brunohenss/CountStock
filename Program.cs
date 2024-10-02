using System;

class CountStock
{
    static void Main()
    {
        Console.WriteLine("Digite o saldo em estoque...");
        int quantidadeEstoque = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantidade de itens que deseja comprar:");
        int quantidadeCompra = int.Parse(Console.ReadLine());

        bool possivelVenda = quantidadeEstoque >= quantidadeCompra;

        /*   (ABAIXO LINHA DESNECESSÁRIA NO CÓDIGO)
                  - BRUNO HENRIQUE 26/09/2024

        Console.WriteLine($"É possível realizar a venda: {possivelVenda}");
        
        */

        if (possivelVenda)
        {
            Console.WriteLine("Venda Realizada...");
        }
        else
        {
            Console.WriteLine("Desculpe, saldo insuficiente em estoque...");
        }
    }
}
