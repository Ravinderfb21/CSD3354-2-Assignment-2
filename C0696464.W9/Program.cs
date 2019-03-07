using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Student Names: Ravinder Singh(c0696464), Hardeep Singh(c0703625)
//CSD3354 SECTION2
//ASSIGNMENT2
//MARCH 6, 2019
namespace C0696464.W9
{
    public class Program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }
         

    public delegate void MyDelegate(ref int intValue);
    public class DelegateExercises
    {
        void Method1(ref int intValue)
        {
            intValue = intValue + 5;
            System.Console.WriteLine(" method1 " + intValue);
        }
            
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            MyDelegate myDelegate1 = new MyDelegate(Method1);
            MyDelegate myDelegate2 = myDelegate + myDelegate1;
            int intParameter= 5;
            myDelegate2(ref intParameter);
           
        }
    }
}
    //-------------------------------------------------------
   