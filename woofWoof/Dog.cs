using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace woofWoof
{
    public class Dog
    {

        public string dogName = "Jet";
        public string dogBark = "\n Woof, Woof \n";
        public int dogAge = 0;
        public int ageInDogYears = 0;
        //here we declare variables that are shared by the two constructors and the properties, and child classes


        /* start properties */
        public string DogName
        {
            get { return this.dogName; }
            set { this.dogName = value; }
        }
        //this the declaration of a property, DogName. It allows get and set; the name can be changed.

        public string DogBark
        {
            get { return this.dogBark; }
        }
        //this the declaration of a property, DogBark. It has no set function because all dogs can simply "Woof, Woof".

        public int DogAge
        {
            get { return this.dogAge; }
            set { this.dogAge = value; }
        }
        //this is a another property, DogAge     
        /* end properties */


        /* start constructors */
        public Dog(string dogName, int dogAge)
        {
            this.dogName = dogName;
            this.dogAge = dogAge;
        }
        //this is a constructor, for the Dog object. It requires the Dog name and age to be input to work.
        /* end constructors */


        /* start functions */
        public int AgeInDogYears(int dogAge)
        {
            ageInDogYears = dogAge * 7;
            return ageInDogYears;
        }
        //this is a function. when we call it in the program, it converts the age in 'human years' to 'dog years'. 
        //See use of void for the distinction of a function

        public void NewDogName(string newName)
        {
            this.dogName = newName;
        }
        //this is a second function, which takes an input, that will re assign the Dog.dogName to the newName input

        public string Bark()
        {
            return dogBark;
        }
        //this is a third function that will present the dog's bark back to the screen. 

        public string whosHound()
        {
            return  "Woof!\n Meet "
                    + this.dogName
                    + "\n he is "
                    + this.dogAge
                    + " years old.";
        }


        /* end functions */
    }
}
