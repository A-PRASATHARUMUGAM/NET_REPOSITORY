
using System.Security.Cryptography.X509Certificates;

namespace Practice_.NET_Program
{

    class Program
    {

        static void Main(string[] args)
        {

            //static method calling
            String_Methods.data();

            //instance method calling
            String_Methods abc = new String_Methods();
            abc.helper();

            //Default calling
            checkmethods("prasath");  //Non Return Type 
            Console.WriteLine(add());      //Return Type 
      


        }

        // Non Return Type Method  
        public static void checkmethods(string name)
        {
            // passing the argument to parameter ;
            Console.WriteLine("My name is "+ name );

        }

        // Return Type Method 
        public static int add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            return c;

        }

            ///***  OTHER FILE TO IMPORT THIS METHOD ****///
           
           
        // Static method to demonstrate a simple functionality
        public static void data()
        {
          Console.WriteLine("Hello World22!");
            
        }

        // Instance method to demonstrate another functionality
        // This method can be called on an instance of the class
        // It is not static, so it requires an object of String_Methods to be created
        // before it can be called.
        // This is useful for methods that need to access instance-specific data or behavior.
        public void helper() {

            Console.WriteLine("Hi");
         }


    }
}