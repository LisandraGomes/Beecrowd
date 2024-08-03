using System;

class URI
{

    static void Main(string[] args)
    {
        var entradaP1 = Console.ReadLine();
        var entradaP2 = Console.ReadLine();

        string[] xyP1 = entradaP1.Split(' ');

        double x1 = Convert.ToDouble(xyP1[0]);
        double y1 = Convert.ToDouble(xyP1[1]);

        string[] xyP2 = entradaP2.Split(' ');

        double x2 = Convert.ToDouble(xyP2[0]);
        double y2 = Convert.ToDouble(xyP2[1]);

        var distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine(Math.Round(distancia, 4));

    }

}