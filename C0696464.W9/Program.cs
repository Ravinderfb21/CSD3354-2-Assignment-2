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
        public static void Main(string[] args)
        {

            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();

        }
    }
        public class DelegateExercises
        {
            public delegate int MyDelegate();

            
          void Method1()
            {
            System.Console.WriteLine("MyDelegate");
            }

           

            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
            }
        }
    }



    //-------------------------------------------------------
   