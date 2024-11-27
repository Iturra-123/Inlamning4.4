using System;

class Program
{
    static void Main()
    {
        Console.Write("Ange låtens längd i minuter: ");
        int minuter = int.Parse(Console.ReadLine());

        Console.Write("Ange låtens längd i sekunder: ");
        int sekunder = int.Parse(Console.ReadLine());

  
        int totalSekunder = minuter * 60 + sekunder;

 
        int minLängd = 2 * 60 + 45;  
        int maxLängd = 4 * 60 + 20; 

      
        if (totalSekunder >= minLängd && totalSekunder <= maxLängd)
        {
            Console.WriteLine("Låten får spelas på radiostationen.");
        }
        else
        {
            Console.WriteLine("Låten får inte spelas på radiostationen.");
        }
    }
}
