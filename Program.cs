using System;

namespace Game
{
    class Program
    {
        static void Main()
        {
            Madlib.Run();

        }
    }
    static class Madlib
    {
        //declare variables
        static string Creature;
        static string Luminous;
        static string Ghastly;
        static string Spectral;
        static string Countryman;
        static string Farrier;
        static string Farmer;
        static string Dreadful;
        static string Apparition;
        static string Hound;
        static string Story;

        public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            End();
        }

            static void Start()
            {
                //Write header and instructions
                Console.WriteLine("--------");
                Console.WriteLine("MadLib!");
                Console.WriteLine("--------");
            }

            static void GetWords()
            {
                //TODO ask player to enter words
                Console.WriteLine("Please enter a noun: ");
                Creature = Console.ReadLine();

                Console.WriteLine("Please enter a adjective: ");
                Luminous = Console.ReadLine();

                Console.WriteLine("Please enter a adjective: ");
                Ghastly = Console.ReadLine();

                Console.WriteLine("Please enter a adjective: ");
                Spectral = Console.ReadLine();

                Console.WriteLine("Please enter a occupation: ");
                Countryman = Console.ReadLine();

                Console.WriteLine("Please enter a occupation: ");
                Farrier = Console.ReadLine();

                Console.WriteLine("Please enter a occupation: ");
                Farmer = Console.ReadLine();

                Console.WriteLine("Please enter a adjective: ");
                Dreadful = Console.ReadLine();

                Console.WriteLine("Please enter a noun: ");
                Apparition = Console.ReadLine();

                Console.WriteLine("Please enter a noun: ");
                Hound = Console.ReadLine();
            }

            static void WriteStory()
            {
                //TODO write out finished story
                Story = "Thay all agreed that it was a huge " + Creature + ", " + Luminous + ", " + Ghastly + ", and " + Spectral + ". I have cross-examined these men, one of them hard-headed " + Countryman + ", one a " + Farrier + ", and one a moorland " + Farmer + ", who all tell the same story of this " + Dreadful + " " + Apparition + ", exactly corresponding to the " + Hound + " of the legend.";
                Console.WriteLine(Story);
            }

            static void End()
            {
                //TODO keep window open and prompt for exit
                Console.WriteLine("Press enter to exit");
                Console.ReadKey();
            }
        
    }   
}
