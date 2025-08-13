
namespace Practice_.NET_Program
{
     class Control_Flow_Statement
    {

        public static void cond()
        {

            // Conditional Statement 
            // if
            // if else
            // else if 
            // Nested if
            // Switch Statement 



            // if 
            int a = 1;
            int b = 2;
            if (a < b)
            {

                Console.WriteLine(true);
            }

            //if else

            if (a > b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //else if 

            if (a < b)
            {
                Console.WriteLine("a is lesser than b");
            }
            else if (a > b){
                Console.WriteLine("a is greater than b ");

            }
            else
            {
                Console.WriteLine("a and b is equal ");
            }


            // Nested if

            if(a < b)
            {
                Console.WriteLine(true);

                if (a != b) { 
                    Console.WriteLine("It is Not equal");
                    
                }
            }else
            {
                Console.WriteLine(false) ;
            }
            

        }
    }
}
