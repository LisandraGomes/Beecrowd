using System; 

class URI {

    static void Main(string[] args) { 
        int distancia = int.Parse(Console.ReadLine());
        decimal combustivel = Convert.ToDecimal(Console.ReadLine());
        
        var kmLitro = Math.Round((distancia/combustivel),3);
        
        Console.WriteLine($"{kmLitro} km/l");
    }

}