using System;
using System.Collections.Generic;


namespace InversionOfControl
{
    class PeanutButterSandwich : IKidFood
    {

        public string Ingredients
        {
            get { return "peanut butter and jelly";  }
        }

        public void Eat()
        {
            Console.WriteLine("yum " + Ingredients);
        }
    }
}
