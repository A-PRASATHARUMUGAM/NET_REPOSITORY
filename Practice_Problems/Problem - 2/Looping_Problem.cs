//Write a program:
//•	Uses a for loop to print numbers 1 to 10
//•	Uses a while loop to find the sum of numbers from 1 to 50
//•	Uses if-else statements to categorize a student's grade based on marks
//•	Uses switch statement to display day of week based on number input (1-7)


namespace Practice_Program.Problems.Problem_2
{
    public class looping
    {


        public void looppb()
        {
            //For loop to print number 1 to 10 
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }



            //Uses a while loop to find the sum of numbers from 1 to 50
            Console.WriteLine("while loop");

            int result=0;
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine() ;

             int  val1= int.Parse(input1); 
            int val2= int.Parse(input2);
            //Math logic
            int check = val2 * (val2 + 1) / 2;
           
            while (val1<=val2)
            {

                result+=val1;
         
                val1++;

            }
            Console.WriteLine(result);
            Console.WriteLine(check);
