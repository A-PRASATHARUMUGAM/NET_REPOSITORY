
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
            //1. For loop to print number 1 to 10 
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }



            //2. Uses a while loop to find the sum of numbers from 1 to 50
            Console.WriteLine("while loop");

            int result = 0;
            Console.WriteLine("Enter the sum of first number ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the sum of second number ");
            string input2 = Console.ReadLine();

            int val1 = int.Parse(input1);
            int val2 = int.Parse(input2);
            //Math logic
            int check = val2 * (val2 + 1) / 2;

            while (val1 <= val2)
            {

                result += val1;

                val1++;

            }
            Console.WriteLine(result);
            Console.WriteLine(check);



            //3. Uses if-else statements to categorize a student's grade based on marks

            Console.WriteLine("Enter your marks of 100 ");
            string input = Console.ReadLine();

            int marks= int.Parse(input);


            //Logic - 1
            string mresult=marks >= 90 ? "A Grade " : marks >= 75 ? "B Grade " : marks >= 35 ? "C Grade" : "No Grade";

            Console.WriteLine(mresult);


            //Logic - 2 
            if (marks >= 90 ) 
            {
                Console.WriteLine("A Grade");
            }
            else if(marks >= 75)
            {
                Console.WriteLine("B Grade");
            }
            else if(marks >= 35)
            {
                Console.WriteLine("C Grade");

            }
            else
            {
                Console.WriteLine("No Grade found");
            }

            //4.Uses switch statement to display day of week based on number input (1-7)


            Console.WriteLine("Enter your days into number like 1 to 7");

            string inputnum = Console.ReadLine();

            int daysnum = int.Parse(inputnum);

            switch (daysnum) 
            {

                case 1:
                    Console.WriteLine("Monday");
                break;

                case 2:
                    Console.WriteLine("Tuesday");
                break;

                case 3:
                    Console.WriteLine("Wedneday");
                break;

                case 4:
                    Console.WriteLine("Thursday");
                break;

                case 5:
                    Console.WriteLine("Friday");
                break;
            
                case 6:
                    Console.WriteLine("Saturday");
                break;
            
                case 7:
                    Console.WriteLine("Sunday");
                break;

                default:

                    Console.WriteLine("not found your day of number");
                break;
            
            
            }




        }
    }
}
