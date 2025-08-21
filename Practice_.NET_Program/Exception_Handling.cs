                                                //Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Practice_Program.Exception_Handling
{
    public class exptHandl
    {


        //Keyword 
        //try,catch,finally,throw
        //Exception -- it means my all error include / Common 
       


        //Types of Errors

        //-  int value = 10/0    -- System.DivideByZeroException
        //-  not create instance of class -- System.NullReferenceException
        //-  accessing index out of range -- System.IndexOutOfRangeException
        //-  accessing null object -- System.NullReferenceException
        //-  invalid cast -- System.InvalidCastException
        //-  invalid format -- System.FormatException
        //-  invalid operation -- System.InvalidOperationException
        //-  file not found -- System.IO.FileNotFoundException
        //-  file already exists -- System.IO.IOException
        //-  out of memory -- System.OutOfMemoryException
        //-  stack overflow -- System.StackOverflowException
        //-  type mismatch -- System.TypeLoadException          
        //-  argument out of range -- System.ArgumentOutOfRangeException

                        //Throwing Exceptions           

        //ArgumentNullException – parameter is null

        //ArgumentOutOfRangeException – value out of valid range

        //InvalidOperationException – object state doesn’t allow the operation

        //NotSupportedException – feature isn’t supported

        //NotImplementedException – placeholder for TODO

        public void checkDisply()
        {
            try
            {
                int a = 10, b = 0;

                int c = a / b;

                Console.WriteLine("The value of c is: " + c);

            }
            catch(DivideByZeroException ex)
            {

                Console.WriteLine("You can't divided by zero");
                Console.WriteLine(ex.Message); // optional: see the system message
            }

            finally
            {
                Console.WriteLine("Exception Successfully ");
            }

      //Exception All    

            try
            {
                List<int> a = new List<int> {  };

                Console.WriteLine(a[2]);


            }catch(Exception ex)
            {

                Console.WriteLine(ex);

            }

                

        }



 


        
        
    }
}
