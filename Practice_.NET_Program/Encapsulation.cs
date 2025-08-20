//Encapsulation - hidding the class
//Abstraction   - hidding the background process

                                            //Program.cs

using Practice_Program.Encapsulation;
using System.Security.Cryptography.X509Certificates;

namespace Practice_Program
{



    public class Program   {


       public static void Main(string[] args)
        {

            Encap checkencp = new Encap();

            checkencp.Name = "Encapsulation Example";



            checkencp.display();


        }   
    }


}

                                                //Encap.cs 

namespace Practice_Program.Encapsulation
{
    public class Encap
    {
        private string name {get; set;}


      

        public string Name
        {
            get{

                return name;
            }

            set
            {
                name = value;

            }

        }

        
        public void display()
        {
            Console.WriteLine($"Name: {Name}");

        }



     
    }

}
