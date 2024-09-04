using System; 

class URI {

    static void Main(string[] args) { 
/*
        Tentativa com alguma função do C#
        int entrada = Convert.ToInt32(Console.ReadLine());
        
        TimeSpan timeSpan = TimeSpan.FromSeconds(entrada);

        int horas = (int)timeSpan.TotalHours;
        int minutos = timeSpan.Minutes;
        int segundos = timeSpan.Seconds;
               
        string retorno = $"{horas}:{minutos}:{segundos}";

        Console.WriteLine(retorno);
*/        
        int entrada = Convert.ToInt32(Console.ReadLine());
        
        int horas = 0;
        int minutos = 0;
        int restouSegundos = 0;

        if(entrada <= 60)
            restouSegundos = entrada;
        
        else{
            horas = entrada / 3600;
            minutos = (entrada % 3600) / 60;
            restouSegundos = entrada % 60;
        }

        string retorno = $"{horas}:{minutos}:{restouSegundos}";
        
        Console.WriteLine(retorno);
    }

}