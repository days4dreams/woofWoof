using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace woofWoof
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog bernardTheBeagle = new Dog("Bernard",3);
            //create a new instance of Dog using the Dog class

            bernardTheBeagle.dogName = "Bernard Wilson";
            //changes the name using the properties get and set methods.

            bernardTheBeagle.AgeInDogYears(3);
            //we call the function ageInDogYears


            Pug peterThePug = new Pug("Peter", 6);
            //create a new instance of Pug, a child class of Dog

            Labrador larryTheLab = new Labrador("Larry", 2);
            //create a new instance of Labrador, a child class of Dog


            Console.WriteLine("Welcome to the Hound Pound...");
            Console.WriteLine(peterThePug.whosHound());
            //call the function whosHound into the command WriteLine
            Console.WriteLine(peterThePug.PugAction());
            //call the function PugAction into the command WriteLine

            Console.WriteLine(bernardTheBeagle.Bark());
            Console.WriteLine(bernardTheBeagle.whosHound());


            Console.ReadKey();

        }
    }
}
