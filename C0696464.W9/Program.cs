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
            try
            {
                delegateExercises.Method3();
                Console.ReadLine();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(" Exception occurred.");
                Console.ReadLine();
            }
        }
    }

    public delegate void MyDelegate();
    public class DelegateExercises
    {
        void Method1()
        {
            throw new System.Exception();
        }
            
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
           
        }
    }
}
    //-------------------------------------------------------
   