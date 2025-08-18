 //            INHERITANCE

 //Inheritance - inherit properties and methods from one class to another.
 //Base Class(parent) the class being inherited from
 //Derived Class(child) - the class that inherits from another class

         //Type of Inheritance
 //Single Inheritance
 //Multiple Inheritance(Only Achieved By Interface)
 //Multilevel Inheritance
 //Hierarchical Inheritance

                                //Base class file 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    public class inheritance
    {




        // Base class // Parent class // Super class
        public static void addmethod()
            {
            Console.WriteLine("inherited");

            }
        

    }
}


                                        //Derived class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{

    //Derived class // Child class // Sub class
    class child  : inheritance   // Single Inheritance  
    {

        
    }
}

