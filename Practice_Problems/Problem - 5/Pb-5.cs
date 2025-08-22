
namespace Practice_Program.Problems.Problem_5
{

//    Problem 5 
//Create a program that demonstrates exception handling:
//•	Handle division by zero
//•	Handle invalid input conversion
//•	Handle array index out of bounds
//•	Create custom exception
//•	Use try-catch-finally blocks

     public class problem5  :Exception
    {
        public void handlpb()
        {
            int result;
            try
            {
                //Array
                int[] arr = {1,2,3,4,5,6,7,8,9,10};

                //Handling Numberic value 
                Console.WriteLine("Enter the first value ");
                int input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second value ");
                int input2 = Convert.ToInt32(Console.ReadLine());

                result = input1 / input2;
                Console.WriteLine($"Division Result : {result}");

                
            
                Console.WriteLine($"Array {arr[input1]}");

                int age = 0;
                if (age <= 18)
                {
                    throw new Exception("Age must 18 above ");

                }
                else {
                    Console.WriteLine("true");

                }

            }
           
            catch(DivideByZeroException)
            {

                Console.WriteLine("Can't not divide by zero");
            }
            catch(FormatException)
            {
                Console.WriteLine("Only put Numeric values ");

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Array index out of bound ");
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Successfully Executed");
            }

        




        }
        
    }
}
