using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        bool hej = true;
        Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
        Random random = new Random();
        int number = random.Next(1, 20);

        // int guess = Convert.ToInt32(Console.ReadLine());
        
        
        int tries = 5;
        
        {
            for (int i = 0; i < tries; i++)
            {
                int guess = int.Parse(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("Correct, good work!");
                }

                else if (guess < number)
                {
                    Console.WriteLine("You guessed too low");
                }
                else if (guess > number)
                {
                    Console.WriteLine("You guessed too high");
                }
                else
                {
                    Console.WriteLine("Try again.");
                }
            }
         
            
            
         }
        Console.WriteLine("You're out of tries, better luck next time!");
        Console.ReadKey();
       

        
    }
}