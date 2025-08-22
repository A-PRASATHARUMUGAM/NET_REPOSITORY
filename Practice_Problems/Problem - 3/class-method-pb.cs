                                        //Program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program.Problems.Problem_3
{


//    Problem 3
//Create a class with the following methods:
//1. A method to check if a number is prime
//2. A method to calculate factorial of a number
//3. A method to reverse a string
//4. A method with parameters and return value
//5. A method that uses method overloading

    public class pbproblem
    {


        public void prime(int primeval)
        {
            //•	A method to check if a number is prime

            int n = Convert.ToInt32(primeval);

            int isprime = 1;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {

                if (n % i == 0)
                {
                    isprime = 0;
                    break;
                }


            }

            if (n == 1)
            {
                Console.WriteLine("Neither prime nor compoiste");
            }
            if (isprime == 1)
            {
                Console.WriteLine("it is prime ");
            }
            else
            {
                Console.WriteLine("it not prime ");
            }

        }


        //2. A method to calculate factorial of a number

        public int fact(int n)
        {
            int result;

            if (n == 0)
            {
                return 1;
            }
            else
            {
                result = n * (n - 1);


            }
            
            return result; 

        }


        //3. A method to reverse a string

        public  void revstr()
        {
            string num = "prasath";

          for(int i=num.Length -1 ; i>=0 ; i--)
            {

                Console.WriteLine(num[i]);
            }

        }


        //4. A method with parameters and return value


         public int passingMethod(int val)
        {

            return val;

        }


        //5. A method that uses method overloading



        //Method -1 
        public void add(int a, int b)
        {

            Console.WriteLine(a + b);


        }


        //Method -2 

        public void add(int a, int b , int c)
        {
            Console.WriteLine(a+b+c);
        }





    }
}
