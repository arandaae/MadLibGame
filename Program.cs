using System;

namespace Madlib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO declare variables
            string Creature;
            string Luminous;
            string Ghastly;
            string Spectral;
            string Countryman;
            string Farrier;
            string Farmer;
            string Dreadful;
            string Apparition;
            string Hound;
            string Story;

            //TODO write out a header
            Console.WriteLine("--------");
            Console.WriteLine("MadLib!");
            Console.WriteLine("--------");

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


            //TODO write out finished story
            Story = "Thay all agreed that it was a huge " + Creature + ", " + Luminous + ", " + Ghastly + ", and " + Spectral + ". I have cross-examined these men, one of them hard-headed " + Countryman + ", one a " + Farrier + ", and one a moorland " + Farmer + ", who all tell the same story of this " + Dreadful + " " + Apparition + ", exactly corresponding to the " + Hound + " of the legend.";
            Console.WriteLine(Story);

            //TODO keep window open and prompt for exit
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();

        }
    }
}
