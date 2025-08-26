namespace Practice_Program.Linq_Program
{
    public class Linq_Operators
    {
        public void OperEmployee()
        {
            List<NewEmployee> employees = new List<NewEmployee> {
            new NewEmployee { Id=1, Name = "Prasath" , salary=5000 },
            new NewEmployee { Id=2, Name = "kandhan" , salary=6000 },
            new NewEmployee { Id=3, Name = "vignesh" , salary=7000 },
            new NewEmployee { Id=4, Name = "sabari" , salary=5800 } ,
            new NewEmployee { Id=5, Name = "Arun" , salary=9000 }  ,
            new NewEmployee { Id=5, Name = "Vijay" , salary=9000 }  ,
            new NewEmployee { Id=5, Name = "Karth" , salary=9000 }  ,
            };

            //Source  - 2
            List<Department> dep = new List<Department> {
            new Department{ DepId = 6, DepName= "Arun"},
            new Department{ DepId = 7, DepName= "Vijay  "},
            new Department{ DepId = 8, DepName= "Karth"},
            };

            //Filter - the Record - using condition to && ||
            //Orderby - order the name
            //Groupby - > //storing method
            /*
                     Employee 1 (object)
                     Employee 2 (object)
                     Employee 3 (object)
                     Employee 4 (object)
                     Employee 5 (object)

            group by  - ID

            ID  - 1
                     Employee 1 (object)

            ID  - 2
                     Employee 2 (object)
                     Employee 2 (object)
                     Employee 2 (object)

            ID  - 5
                     Employee 5 (object)
                     Employee 5 (object)
                     Employee 5 (object)
                     Employee 5 (object)

             */

            //Join by

            var records = (from emp in employees
                           where emp.salary >= 6000
                           orderby emp.Id
                           group emp by emp.Id into emp
                           select emp);

            foreach (var record in records)
            {
                //Accessing the Key
                Console.WriteLine($"id {record.Key} and {record.Count()}");

                //Accessing the value
                foreach (var val in record)
                {
                    Console.WriteLine(val.Id + val.Name);
                }
            }    

            var EmpJoinRecords = (from empjoin in employees
                                  join depval in dep on empjoin.Name equals depval.DepName
                                  select new { EmpName = empjoin.Name , DeptName=depval.DepName});

            foreach (var record in EmpJoinRecords)
            {
                Console.WriteLine(record.EmpName);
                Console.WriteLine(record.DeptName);
            }
        }
    }

    public class NewEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
    }

    public class Department
    {
        public int DepId { get; set; }
        public string DepName { get; set; }
    }
}