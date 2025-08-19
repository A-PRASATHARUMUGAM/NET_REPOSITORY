                                    // Program 

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

            Boss bossclass= new Boss(2,"kandhan","Genx",40000);

            //Hierarchical Inheritance
            ExternalEmployee external =new ExternalEmployee(3, "ExternalEmp", 30000);

            external.BossDetails();

           

            //interface - Function call only
            checkemp.Salarydetails();

            checkemp.EmployeeDetails();

                                
            //Multilevel inheritance 
            bossclass.Salarydetails();

          



            

        }
         

    }


}


                                                //Bass.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    public class Boss : Employee
    {
     
        //contructor
           
        public Boss(int employeeId,string employeeName,string companyName,int salary ) : base(employeeId,employeeName,companyName,salary)

        {
            
        }
        public void BossDetails()
        {
            Console.WriteLine($"EmployeeId: {EmployeeId} EmployeeName: {EmployeeName} is a Boss");
        }

    }
}


                                                //Employee.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    //Multiple Inheritance using Interface
   public class Employee : child , EmployeeSalary  
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


        //Multilevel Inheritance



    }
}


                                             //Child.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{

    //Derived class // Child class // Sub class
   public class child : inheritance    // Single Inheritance  
    {


 
        public  void firstclass()
        {
            Console.WriteLine("first class ");
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


                            //Hierarchical inheritance 

                            // ExternalEmployee.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    public class ExternalEmployee : Boss
    {



        public int ExternalEmployeeId { get; set; }
        public string ExternalEmployeeName { get; set; }

        public int ExternalSalary { get; set; }

        public ExternalEmployee(int employeeId, string employeeName, int salary) : base(employeeId, employeeName, "ExternalCompany", salary)
        {
            this.ExternalEmployeeId = employeeId;
            this.ExternalEmployeeName = employeeName;
            this.ExternalSalary = salary;
        }

        public void ExternalEmployeeDetails()
        {
            Console.WriteLine($"External EmployeeId: {ExternalEmployeeId} External EmployeeName: {ExternalEmployeeName}");
        }
    }
}
