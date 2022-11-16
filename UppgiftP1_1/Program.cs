using System;

namespace UppgiftP1_1
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hej och välkommen till lyckohjulet, vänligen skriv in ett tal mellan 1-25");
            int inmatatTal=int.Parse(Console.ReadLine());

            Random random=new Random();
            int hjuletsnummer=random.Next(1, 26);

            Console.WriteLine($"Lyckohjulet stannade på {hjuletsnummer}");

            if (inmatatTal == hjuletsnummer)
            {
                Console.WriteLine("Du vann lyckohjulet, grattis!");
            }

            else
            {
                Console.WriteLine("Du förlorade tyvärr");
            }


        }
    }
}