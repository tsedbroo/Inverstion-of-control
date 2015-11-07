using System;
using System.Collections.Generic;


 namespace InversionOfControl {
  public  class Mom
    {    
         private static Dictionary<string, IKidFood> MomsHelp = new Dictionary<string, IKidFood>();
      
        // example of Singleton pattern only one mom allowed
         private static Mom single_instance;

        private Mom()   // what's the deal with a private contructor  ?
           
            // add to my Dictionary
        {
            MomsHelp.Add("A PeanutButter Sandwich", new PeanutButterSandwich());
            MomsHelp.Add("A Cheese Sandwich", new CheeseSandwich());
        }

        public static IKidFood Gimme(string key)
        {
            if (single_instance == null)
                single_instance = new Mom();
            if (MomsHelp.ContainsKey(key))
                return MomsHelp[key];
            else
                throw new KeyNotFoundException("sorry kid you're going hungry");

            // how could you give him an apple when he asks for something he is not supposed to have?
        }
    }
}
