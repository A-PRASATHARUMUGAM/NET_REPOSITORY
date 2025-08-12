
namespace Practice_.NET_Program
{
    //STRING AND ITS METHODS

    /*
     
1. String Manipulation
    Concatenation +
    Formatting {0} {1}, a,b;
    Interpolation $ {a} {b}
    Verbatim @[/n and raw space]

2. String Methods
    Uppercase and Lowercase
    SubString
    Trim

3. String Operations
    IndexOf
    IsNull Or WhiteSpace - null or blank
    true else false



                                        //Console Methods 
        CONSOLE METHODS
    Console.Write(); - Same Line
    Console.WriteLine(); - New Line
    Console.Read(); - ASCII
    Console.ReadLine(); - Raw Input
    Console.ReadKey(); - Hold to Read

       */


    class String_Methods
    {

        // Static method to demonstrate a simple functionality
        public static void data()
        {
          Console.WriteLine("Hello World22!");
            
        }

        // Instance method to demonstrate another functionality
        // This method can be called on an instance of the class
        // It is not static, so it requires an object of String_Methods to be created
        // before it can be called.
        // This is useful for methods that need to access instance-specific data or behavior.
        public void helper() {

            Console.WriteLine("Hi");
         }

        public static void pcstring()
        {


            //1. String Manipulation

                //1. Concatenation
                     string name = "Prasath";
                     int age = 21;
                     Console.WriteLine("my name is " + name + " and my age is " + age);

                //2. String Formatting - indexed to implement
                  Console.WriteLine("my name is {0} and my age is {1} ",name,age);


                //3. Interpolation $ { a} { b}
                     Console.WriteLine($"my name is {name} and my age is {age}");

                //4.Verbatim    @[/ n and raw space]
                     Console.WriteLine(@"my name is {0} and my age is {1}", name, age);



            //2.String Methods
                string name1 = "prasath";
                string name2 = "PRASATH ARUMUGAM";
             
                //Uppercase 
                         Console.WriteLine(name1.ToUpper());

                //Lowercase
                         Console.WriteLine(name2.ToLower());

                //concate
                string firstName = "Prasath";
                string lastName = "Arumugam";
                string fullName = string.Concat(firstName, " ", lastName); // Concatenates first and last name with a space

                // Trim
                string str = "      Hello World!   ";
                string trimmedStr = str.Trim(); // Removes leading and trailing spaces
                Console.WriteLine(trimmedStr); // Outputs: 'Hello World!'

                // SubString
                string sub = name2.Substring(0, 6); // Extracts "PRASAT"
                Console.WriteLine(sub);


            // 3.String Operations

                //IndexOf
                string sentence = "Hello, World!";
                int index = sentence.IndexOf("World!");
                Console.WriteLine(index);


            //IsNull Or WhiteSpace - null or blank
             
            string input = " ";
            string input2 = "prasath";

            bool data = String.IsNullOrWhiteSpace(input);
            bool data2 = String.IsNullOrWhiteSpace(input2);

            Console.WriteLine(data);
            Console.WriteLine(data2);




            //Console Methods 


            int checkInp=Console.Read();
            string checkInp2=Console.ReadLine();



     



        }


    }
}
