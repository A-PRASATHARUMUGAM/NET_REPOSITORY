namespace Practice_Program.Linq_Program
{
    public class Linq

    {
        private class employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Department
        {
            public int DepId { get; set; }
            public string DepName { get; set; }
        }

        public static void checklist()
        {
            //Source  - 1
            List<employee> employees = new List<employee> {
                new employee{ Id = 1, Name= "prasath"},
                new employee{ Id = 2, Name= "vignesh "},
                new employee{ Id = 3, Name= "sabari"},
            };

            //Basic Query Syntax - 1
            //var records = from variableName in source select variableName;
            //1. Initialize only // 2.using .toList() Immediate Retrive
            var records = (from prod in employees select prod).ToList();

            //late update also included
            employees.Add(new employee { Id = 4, Name = "kandhan" });

            // Retrive to store the data
            foreach (var employee in records)
            {
                Console.WriteLine(employee.Id);
                Console.WriteLine(employee.Name);
            }

            Console.WriteLine("method 2 ");
            //Method Query Syntax - 2
            //var records2 = employees.Select(s=>s);
            //using lambda expression

            var records2 = employees.Select(s => s);

            foreach (var prod in records2)
            {
                Console.WriteLine(prod.Id);
                Console.WriteLine(prod.Name);
            }
        }
    }
}