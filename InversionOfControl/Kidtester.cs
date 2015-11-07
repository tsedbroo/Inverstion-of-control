using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InversionOfControl
{
    class Kidtester
    {
        static void Main(string[] args)
        {
             CuteKid billy = new CuteKid();
             try
             {
                 billy.AskMom("A PeanutButter Sandwich");
                 billy.AskMom("A Cheese Sandwich");
               
               
                 billy.EnjoySnacks();
             }
             catch (KeyNotFoundException e)
             {
                 Console.WriteLine(e.Message);
             }

        }
    }
}
