using System;


namespace InversionOfControl
{
   class CheeseSandwich: IKidFood
    {
        public string Ingredients
        {
            get { return "cheese and bread"; }
        }

        public void Eat()
        {
             Console.WriteLine("yum " + Ingredients);
        }
    }
}
