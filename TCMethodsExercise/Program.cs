using System;

namespace TCMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GatherInfo();
            Console.WriteLine(Div(250, 10, 5, 1));
        }

        public static void GatherInfo()
        {
            Console.WriteLine("Welcome to Terrence's story time fun parade!");
            Console.WriteLine("Today we will be writing a story together! Every good story needs a protagonist. What should we call ours?");
            Console.WriteLine();
            string name = Console.ReadLine();
            Console.WriteLine($"OOH! {name} is a great name! I already have some ideas!");
            Console.WriteLine($"Now what is {name}'s favorite game?");
            Console.WriteLine();
            string game = Console.ReadLine();
            Console.WriteLine("I like that one too!");
            Console.WriteLine("Okay, we're almost done, but I need a whole number.");
            Console.WriteLine();
            int jersey = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And finally, we'll need your favorite instrument!");
            Console.WriteLine();
            string music = Console.ReadLine();
            Console.WriteLine("Thanks so much for all your help! I'm going to work on that story now. Press enter to hear it!");
            Console.ReadLine();
            Console.WriteLine($"One day, an amazing person named {name} was at home minding their business.");
            Console.WriteLine("Well, not a literal business, but they certainly weren't bothering anyone.");
            Console.WriteLine($"Then, suddenly, in the middle of a rousing game of {game}, {name} heard a noise at the window...");
            Console.WriteLine($"Deeply irritated, {name} paused {game} to investigate, and golly were they glad they did,");
            Console.WriteLine($"because right there, standing outside {name}'s window was a famous athlete! You know the one!");
            Console.WriteLine($"It was #{jersey} from that really good team! {name} was so happy that he started hearing {music}s playing in his head!");
            Console.WriteLine($"That's when it all started to feel strange, and {name} woke up. \"I've really got to stop falling asleep playing games!\" {name} chuckled.");
            Console.WriteLine("THE END, End, end...");
        }

        public static int Add(params int[] nums)
        {
            int total = 0;

            foreach (int num in nums)
            {
                total += num;
            }

            return total;
        }

        public static int Sub(params int[] nums)
        {
            int total = nums[0]*2;

            foreach (int num in nums)
            {
                total -= num;
            }

            return total;
        }

        public static int Multi(params int[] nums)
        {
            int total = 1;

            foreach (int num in nums)
            {
                total *= num;
            }

            return total;
        }

        public static int Div(params int[] nums)
        {
            int total = nums[0] * nums[0];

            foreach (int num in nums)
            {
                total /= num;
            }

            return total;
        }
    }
}
