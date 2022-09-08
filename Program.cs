namespace random_number_gen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int val = r.Next(1, 100);
            int guess = 0;
            bool correct = false;

            int attempts = 0;
            Console.WriteLine(val);




            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");

            Console.WriteLine("You only have 7 tries.");
            while (!correct && attempts < 7)
            {
                Console.Write("Guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("That's not a number.");
                    attempts++;
                    Console.WriteLine("You wasted " + attempts + " attempts of 7.");
                    continue;
                }
                if (guess < val)
                {
                    Console.WriteLine("No, the number I'm thinking is higher than that number.");
                    attempts++;
                    Console.WriteLine("You wasted " + attempts + " attempts of 7.");
                    
                }
                else if (guess > val)
                {
                    Console.WriteLine("No, the number I'm thinking is lower than that number.");
                    attempts++;
                    Console.WriteLine("You wasted " + attempts + " attempts of 7.");
                }
                else
                {
                    correct = true;
                    Console.WriteLine("You guessed right!");

                   
                    if (attempts == 7)
                    {
                        Console.WriteLine("You failed!");
                        break;
                    }
                    

                    

                    

                }
            }
        }
    }
}
                
   



    

