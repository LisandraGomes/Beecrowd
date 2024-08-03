using System;

class URI
{

    static void Main(string[] args)
    {
        double x = 60;
        double y = 90;

        double distancia = Convert.ToInt32(Console.ReadLine());

        double diferencaVelocidade = y - x;

        double calculo = distancia / diferencaVelocidade;

        int minutos = Convert.ToInt32(calculo * 60);

        Console.WriteLine($"{minutos} minutos");
    }

}