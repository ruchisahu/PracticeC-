using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericDemoOfBoxingUnBoxing
{
    class Demo
    {
        public void Test()
        {
            int number1 = 1;

            var arrayList1 = new ArrayList();
            // This statement boxes the Int32 value as a System.Object.
            arrayList1.Add(number1);
            // This statement unboxes the Int32 value.
            int number2 = (int)arrayList1[0];


            var genericList1 = new List<Int32>();
            //This statement adds an Int32 value without boxing.
            genericList1.Add(number1);
            //This statement retrieves the Int32 value without unboxing.
            int number3 = genericList1[0];
            {
                Console.WriteLine("generic");
            }
        }
}
}
