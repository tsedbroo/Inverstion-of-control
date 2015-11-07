using System;
using System.Collections.Generic;
using System.Linq;


namespace InversionOfControl
{
    class CuteKid
    {
        private List<IKidFood> MySnacks = new List<IKidFood>();

       
        public void AskMom(string food)
        {
           MySnacks.Add( Mom.Gimme(food)) ;
        }

        public void EnjoySnacks()
        {
            MySnacks.ForEach(aSnack => aSnack.Eat());
        }
       

    }
}
