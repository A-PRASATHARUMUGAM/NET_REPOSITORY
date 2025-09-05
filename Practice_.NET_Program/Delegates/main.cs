//Delegate
//What is Delegate
//Net memory Allocation
//How to Delegate Work

namespace Practice_Program
{
    //Delegate Life Cycle

    //- 1. Delegate Declearation --
    //- 2. Create Delegate ---
    //- 3. Assign Method --
    //- 4. Invoke Method(s) to Delegate
    public class Program
    {
        //1. Declare the delegate
        public delegate void DelegateType();

        public class PracticeClass
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public void Display()
            {
                Console.WriteLine("display Method");
                Console.WriteLine(Id);
                Console.WriteLine(Name);
            }
        }

        public static void sayHello()
        {
            Console.WriteLine("Say hello it from static method ");
        }

        public static void Main(string[] args)
        {
            //2. create delegate
            DelegateType functionPointer;

            PracticeClass practiceClass = new PracticeClass();
            practiceClass.Id = 1;
            practiceClass.Name = "prasath";

            //3.Assign Non-Static Method to pointer
            functionPointer = practiceClass.Display;

            //static method calling
            functionPointer += sayHello;

            //Another way to Assign
            functionPointer = new DelegateType(sayHello);

            //Equal 1
            //practiceClass.Display();

            //4. Invoke Method
            //Equal 2
            functionPointer();

            //Another Invoke
            //functionPointer.Invoke();

            Console.WriteLine(functionPointer.Target);
            Console.WriteLine(functionPointer.Method);

            foreach (var delObj in functionPointer.GetInvocationList())
            {
                Console.WriteLine(delObj.Method);
            }
        }
    }
}