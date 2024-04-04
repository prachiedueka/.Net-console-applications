using System;

class Program
{
    public static void Main()
    {
        //implicit conversion
        int i = 125;    //Assignment operator
        float j = i;
        Console.WriteLine("Implicit conversion = "+j);

        //Explicit conversion
        float m = 878.3232F;
        //int n = Convert.ToInt32(m);
        int n = (int)m;
        Console.WriteLine("Explicit conversion = " + n);

        //Conditional operator
        int age = 25;
        bool result = age == 25? true: false;
        Console.WriteLine("Conditional operator = "+ result);

        int value = 1;
        int[] Array = new int[4];
        for (int runs = 0; runs < 3; runs++)
        {
            Array[runs] = value;
            value = value + 3;
        }
        Console.WriteLine("Array is = " + Array[2]);

        Program ProgramObj = new Program();
        ProgramObj.EvenNumbers(20);
    }
    public void EvenNumbers(int Value)
    {
        int count = 0;
        while(count <= Value)   //Comparision operator
        {
            Console.WriteLine(count);
            count = count + 2;  //Arithmetic operator
        }
        
    }
}
