using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace woofWoof
{
    public class Pug : Dog
    {
        public Pug(string dogName, int dogAge) : base(dogName, dogAge)
        {   }
        //instruct that pug is child of dog class, use contructor with same inputs

        public string pugAction = "...drooling, sleeping and eating";
        //create a string to describe pug-only actions. Cannot be used by other dog objects

        public string PugAction()
        {
            return dogName + " likes " + pugAction;
        }
        //create a function to return the pugAction string to screen
    }
}
