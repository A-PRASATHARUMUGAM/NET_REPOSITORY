
//1.class and object
//2. getters and setters
                                            //Main Class File
using Practice_Program;
using System.Security.Cryptography.X509Certificates;

namespace Practice_progrm
{



    class Program
    {
        public static void Main(string[] args)
        {

       
            object_oriented compData = new object_oriented();
            object_oriented obj2 = new object_oriented();
            //Fist call
            compData.DisplayCompanyDetails();

                                        //Method 1
                             //using setter to set the name
                             compData.id = 2;

                        
                  compData.SetName("kandhan");

            //Second call
            compData.DisplayCompanyDetails();

            //newobject
            obj2.id = 3;
            obj2.SetName("vignesh");


                        //getting the value name using getter
                        Console.WriteLine(obj2.GetName());

            //Third call
            obj2.DisplayCompanyDetails();



                            //Method 2
            //getting the value of address
            Console.WriteLine($" ch  "+compData.Add);

            //setting the value of address
            compData.Add="VPM";


            compData.addfunction();


                                //Method 3


            compData.method3getset();


            //getting the value of email
            Console.WriteLine($"Email : {compData.Email}");

            //setting the value of email
            compData.Email = "kandhanemail";


            compData.method3getset();









        }




    }
    
}
                                    //Class File 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Practice_Program
{
     class object_oriented
    {
        //class members
          public int id=1;
          private string name="prasath";
          private string address="chennai";
          public string Email { get; set; } = "PRASATHARUMUGAM";


                //Method 1      
                //1.Setters

        public void SetName(string newName)
        {
            this.name = newName;
        }

        //2.Getters
           public string GetName()
        {
            return this.name;
        }




        public void DisplayCompanyDetails() 
        {
            Console.WriteLine($" id {id} name {name} ");


        }

         //Method 2
        //New method to set and get the value of address
        public void addfunction()
        {
            Console.WriteLine($"address : {address}"); 
        }

      


        public string Add
        {
            get { return address; }


            set { address = value; }    
        }


        //Method 3

        public void method3getset()
        {
            Console.WriteLine(Email); 
        }






    }
}
