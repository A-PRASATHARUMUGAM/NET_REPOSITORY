                                            // Program.cs

using Practice_Program.Abstarction;

namespace Practice_Program
{



    public class Program   {

    

       public static void Main(string[] args)
        {

            Newemp checkemp=new Newemp("BOSS","kandhan");

            checkemp.EmployeeSalaryDetails();


            checkemp.companyDetails();

        }   
    }


}

                                            //Company.cs    Base class        


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program.Abstarction
{
    public abstract class Company
    {
        public  string Name { get; set; }


        public Company(string name)
        {
            this.Name = name;
        }


        public abstract void companyDetails();
      

    }
}

                                                //Newemp -- Derived Class 

namespace Practice_Program.Abstarction
{
    class  Newemp : Company
    {

        public string EmployeeType { get; set; }

        public Newemp(string employeetype , string name ):base(name)
        {
            this.EmployeeType=employeetype; 

        }

        public void EmployeeSalaryDetails()
        {
            if (EmployeeType.ToUpper() == "BOSS")
            {
                salary();

            }
            else
            {
                Console.WriteLine("Your are not a boss");

            }

        }   

          private void salary()
        {
            Console.WriteLine("40 thousand ");
        }

        public override void companyDetails()
        {
            Console.WriteLine($" employee name {Name}");
        }
    }
}

