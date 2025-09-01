
namespace Practice_Program
{
    public class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static void Display()
        {
            Console.WriteLine("display Method");
        }

        public static void Main(string[] args)

        {
            //1. Static Method call to "Class Name"
            //ClassName.MethodName();

            //2. Non-static Method call to Reference Name
            //ObjectName.MethodName();

            //Reference   - Stack Memory
            //Program Program;

            //Object      - Heap Memory
            new Program();

            //+ pointing = Instance

            //Reference + Object  = instance

            Program program = new Program();
           
            //Asssign Object 1
            program.Id = 1;
            program.Name = "Prasath";

            //Combain p1 and p2
            Program program2 = program;

            //program = null;

            //Object 1
            Console.WriteLine(program.Id);
            Console.WriteLine(program.Name);

            //Object 2
            program2.Id = 2;
            program2.Name = "kandhan";

            Console.WriteLine(program2.Id);
            Console.WriteLine(program2.Name);

            //------------------------------------

            //Object 1
            Console.WriteLine(program.Id);
            Console.WriteLine(program.Name);

            //Object 2
            Console.WriteLine(program2.Id);
            Console.WriteLine(program2.Name);
        }

        //Delegate Life Cycle

        //- Delegate Declearation
        //- Create Delegate
        //- Assign function(s) to Delegate
        //- Invoke Method(s) to Delegate



    }
}