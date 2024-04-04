using System;

namespace TestConstructor
{
    public class Test
    {
        int Length, Breadth;
        int Result;

        //default
        public Test()
        {
            this.Length = 2;
            this.Breadth = 6;
        }

        //parameterized
        public Test(int length, int breadth)
        {
            this.Length = length;    
            this.Breadth = breadth;  
        }

        //Copy
        public Test(Test t)
        {
            this.Length = t.Length;
            this.Breadth = t.Breadth;
        }

        void Calculate()
        {
            Result = Length * Breadth;
            Console.WriteLine("Area is = " + Result);
        }

        // Main method
        public static void Main(string[] args)
        {
            Test testObj = new Test();
            testObj.Calculate();

            Test TestParamObj = new Test(2, 4);
            TestParamObj.Calculate();

            Test TestCopyObj = new Test(testObj);
            TestCopyObj.Calculate();
        }
    }
}
