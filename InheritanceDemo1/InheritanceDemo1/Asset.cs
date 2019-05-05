using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo1
{
    // public int Price{ get; set; }
    class Asset1
    {
        public virtual void Price()
        {
            Console.WriteLine("base class");
        }
        public void Quantity()
        {
            Console.WriteLine("base class");
        }
    }

        class Asset2 : Asset1
        {
            public override void Price()
            {
                Console.WriteLine("child class");
            }
            public void stock()
            {
                Console.WriteLine("child class");
            }
        }
    
    
    

}
