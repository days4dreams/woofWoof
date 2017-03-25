using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace woofWoof
{
    public class Labrador : Dog
    {
        public Labrador(string dogName, int dogAge) : base(dogName, dogAge)
        { }
        //instruct that Labrador is child of dog class, use contructor with same inputs

        public string labradorAction = " waiting paitently for your next instruction";
        //create a string to describe labrador-only actions. Cannot be used by other dog objects

        public string LabradorAction()
        {
            return dogName + " likes " + labradorAction;
        }
        //create a function to return the labradorAction string to screen
    }
}
