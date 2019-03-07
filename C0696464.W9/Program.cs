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
    class Program
    {
        static void Main(string[] args)
        {

            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method2();

        }

        public class DelegateExercises
        {
            public delegate void MyDelegate();
            void Method1()
            {
                Console.WriteLine("Method1");
                Console.ReadLine();
            }

            public void Method2()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }
        }
    }
}


    //-------------------------------------------------------
   