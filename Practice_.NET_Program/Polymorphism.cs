                            //  Polymorphism

//POLYMORPHISM
//Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.
//Polymorphism uses those methods to perform different tasks

//Type of Polymorphism
//1. Static or Compile Time Polymorphism
// -- Method Overloading 

//2.Dynamic / Runtime Polymorphism   
// --- Method overriding


                                //Program.cs 
using Practice_Program.Domain;
namespace Practice_Program
{


    public class Program   {



        public Program() 

        { 
            Console.WriteLine("I am a Constructor");


        }

        public static void Main(String[] args)
        {
       
           

            Polymorphism polycheck = new Polymorphism();

            bus checkbus1 = new bus(4);

            simibus checkbus2 = new simibus(5);

            //Method Overloading - 2
            polycheck.add(10,20,30,40);


            //Method Overriding 
            bus checkbus3 = new simibus(20);

            checkbus3.wheelsinbus();







        }


    }


}


                                    //bus.cs  --- Base class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    public class bus 
    {
        public int Wheels { get; set; }


        public bus(int wheelsbus)
        {
            this.Wheels = wheelsbus;


        }
        public virtual void wheelsinbus()
        {
            Console.WriteLine($"This base class : {Wheels}");
        }

        public void display()
        {
            Console.WriteLine("This is base class");
        }
    }

}


                                //simibus.cs  -- Derived class


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    public class simibus : bus  
    {

        public simibus(int wheels ):base(wheels)
        {
          
        }
       
       //Method Overriding 
        public override void wheelsinbus()
        {
            Console.WriteLine($"This derived class : {Wheels}");
        }


        public void display2()
        {
            Console.WriteLine("This is base class");
        }
    }

}


//polymorphism.cs 

using Practice_Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice_Program
{
    public class Polymorphism
    {
          public  void poly()
        {
            Console.WriteLine("Hello World ");
        }



        //Method Overloading  -- same name different signature Eg: parameter 
        // -- first check how many parameters are there, -- then check the type of parameters then call the method

        public void add(int a, int b)
        {
            Console.WriteLine("Addition :"+( a+b));
        }

        public void add(int a, int b ,int c) 
        {
            Console.WriteLine("Addition 2 :"+(a+b+c));

        }

        public void add(int a, int b , int c , int d)
        {
            Console.WriteLine(a + b + c + d);
        }








    }
}

//Method Overriding 
// new keywoard implement other file 



                                         // Program.cs           

using Practice_Program.Domain;
namespace Practice_Program
{


    public class Program   {



        public Program() 

        { 
            Console.WriteLine("I am a Constructor");


        }

        public static void Main(String[] args)
        {





            simibus simi = new simibus(5);

            simi.wheelsinbus();


        }


    }


}



                                            //simibus.cs  -Derived Class


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    public class simibus : bus  
    {

        public simibus(int wheels ):base(wheels)
        {
          
        }

                    //Implement to new keyword it is don't override show is in first becasue is it " new "
                    //Method Overriding 
        public new void wheelsinbus()
        {
            Console.WriteLine($"This derived class : {Wheels}");
        }


        public   void buscapacity() 
        {
            Console.WriteLine("this is derived ");
            Console.WriteLine("40 members only");
        }
    }

}



                                            //bus.cs  -     Base Class 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    public class bus 
    {
        public int Wheels { get; set; }


        public bus(int wheelsbus)
        {
            this.Wheels = wheelsbus;


        }
        public new void wheelsinbus()
        {
            Console.WriteLine($"This base class : {Wheels}");
        }

        public  void buscapacity()
        {
            Console.WriteLine("This is base");
            Console.WriteLine("20 members only");
        }
    }

}
