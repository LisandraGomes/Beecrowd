using System;

class URI
{

    static void Main(string[] args)
    {
        int litrosConsumidos = 12;
        int horas = Convert.ToInt32(Console.ReadLine());
        int kmH = Convert.ToInt32(Console.ReadLine());

        double calculoQuantidadeKm = kmH * horas;
        double calculoQuantidadeLitros = calculoQuantidadeKm / litrosConsumidos;

        Console.WriteLine($"{calculoQuantidadeLitros:F3}");
    }

}