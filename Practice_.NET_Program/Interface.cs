                                    // Program.cs 

namespace Practice_Program
{


    public class Program   {



        public Program()
        { 
            Console.WriteLine("I am a Constructor");


        }

        public static void Main(String[] args)
        {
       
            Program checonst = new Program();

            Employee checkemp = new Employee(1,"prasath","Genx",12000);

            //interface - Function call only
            checkemp.Salarydetails();

            checkemp.EmployeeDetails();
          



            

        }
         

    }


}



                                // Employee.cs 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
     class Employee : child , EmployeeSalary  
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string EmployeeComp { get; set; }

        public int Salary { get; set; }

     
        public Employee(int employeeId, string employeeName,string companyName, int salary)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName= employeeName;
            this.EmployeeComp = companyName;
            this.Salary=salary; 

        }



       public void EmployeeDetails()
        {
            Console.WriteLine($"EmployeeId: {EmployeeId} EmployeeName: {EmployeeName}");


        }

        public void EmployeeComDetails()
        {
            Console.WriteLine($"EmployeeId: {EmployeeId} EmployeeName: {EmployeeName} is a Compliant Employee");
        }

        public void Salarydetails()
        {
            Console.WriteLine(Salary);

        }

        
    }
}


                                //Interface.cs 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{

    //Interface - Function call only 
   
      interface  EmployeeSalary
    {

        public void Salarydetails();



    }
}
