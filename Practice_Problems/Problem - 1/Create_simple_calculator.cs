
                        //        Create a simple calculator program that


//•	Declares variables of different data types(int, double, string, bool)
//•	Takes two numbers as input from user
//•	Performs basic arithmetic operations(+, -, *, /, %)
//•	Uses comparison operators to check if first number is greater than second
//•	Uses logical operators to check if both numbers are positive


namespace Practice_Program.Problems
{
    public  class  SampleCalculator
    {
        
        public void simpleCalculator()
        {
            Console.WriteLine("Enter the First Value");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the Second Value");
            string input2 = Console.ReadLine();

            //Handling errors 
            try
            {

                //convert interger 
                int val1 = int.Parse(input1);
                int val2 = int.Parse(input2);

                    //Check the Greater Value 
                    if (val1 > val2)
                    {

                            //check the positive integer 
                            if (val1 > 0 && val2 > 0)
                            {

                                Console.WriteLine($"Addition : {val1 + val2}");
                                Console.WriteLine($"Subtraction : {val1 - val2} ");
                                Console.WriteLine($"Multiplication : {val1 * val2} ");
                                Console.WriteLine($"Division : {val1 / val2} ");
                                Console.WriteLine($"Modules Div : {val1 % val2} ");

                            }
                            else
                            {
                                Console.WriteLine("only put the positive value");
                            }



                    }
                    else
                    {
                        Console.WriteLine("Can you put the fist value is greater ");
                    }

                    }

            catch (FormatException)
            {
                Console.WriteLine("Don't use character only user numeric values ");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }









    }
}
