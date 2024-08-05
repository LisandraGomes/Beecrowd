using System;

class URI
{

    static void Main(string[] args)
    {
        int entrada = Convert.ToInt32(Console.ReadLine());
        int[] notasBrl = { 100, 50, 20, 10, 5, 2, 1 };
        var valorRestante = entrada;
        int quantidadeNotas = 0;

        Console.WriteLine(entrada);

        foreach (int nota in notasBrl)
        {
            quantidadeNotas = valorRestante / nota;

            Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {nota},00");
            valorRestante %= nota;
        }
    }

}