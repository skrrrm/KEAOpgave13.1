using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEAOpgave13._1
{
    class Coin
    {
        // Variables of the class
        // Private variables is named with small letters
        private static Random ranObj = new Random();
        private char value;

        // Constructor of the class
        // Called when creating objects
        // A constructor must have the same name as the class
        // A constructor does not return any values
        public Coin()
        {
            throw();
        }

        // Properties of the class
        // Properties are public - you can read or write to the variable.
        // In this case - we only read.
        // Within a property you can limit the variables however you wish - 
        // That way no unwanted values are applied.

        // A property is named the same as a variable but with big first letter.
        public char Value
        {
            get { return value; }
        }

        // Method of the class
        // Public. Big first letter. Always ().
        // A method can return a value or not. A void method does not return anything.
        public void Throw()
        {
            int k = ranObj.Next(2);
            if (k == 0)
                value = 'T'; // Tails
            else
                value = 'H'; // Heads
        }

        // A method can be implemented in several ways with the same name.
        // As long as the parameters are different.
        // If this method is called with the value 'true'
        // then the chance of rnadObj.Next(3) is 2/3 to become 'H' (heads)
        public void Throw(Boolean b)
        {
            ranObj = new Random();
            if (b == true)
            {
                int k = ranObj.Next(3);
                if (k == 0)
                    value = 'T'; // Tails
                else
                    value = 'H'; // Heads
            }
            else Throw();
        }
    }
}
