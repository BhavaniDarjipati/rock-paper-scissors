using System;

namespace rock_paper_scissors 
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random(); // creating a new random number
            int computerChoice = r.Next(3); // Declaring int variable 
            Console.WriteLine("rock paper scissor");// welcome message 
            string userChoice = Console.ReadLine(); // declaring string variable 
          
            // producing a random move for the computer player and asking human for their choice

            {

                if (computerChoice == 0)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("user chose rock");
                        Console.WriteLine("is this draw");
                    }

                    else if (computerChoice == 1)
                    {
                        if (userChoice == "paper")
                        {
                            Console.WriteLine("The computer chose paper");
                            Console.WriteLine("user chose paper");
                            Console.WriteLine(" is this draw");

                        }
                        else if (computerChoice == 2)
                        {
                            if (userChoice == "scissors")
                            {
                                Console.WriteLine("The computer chose scissors");
                                Console.WriteLine("user chose scissors");
                                Console.WriteLine("is this draw");
                            }
                                                       
                        }
                    }
                }
       
            }
        }
    }
}