
using System.Threading.Channels;

namespace Practice_.NET_Program
{
     class Looping_Statement()
    {


                    //         LOOPS
        // For
        // While (check then run code block)
        // Do while (run code block then it will check)
        // Foreach (loop through array or list)
        public static void Loop()
        {

            // For

            int i = 0;
            for (i=0; i < 10; i++)
            {
                Console.WriteLine("For Loop "+i);
            }

            //While
            int b = 0;
            while (b < 10)
            {
                Console.WriteLine("While Loop "+b);
                b++;
            }

            //Do While
                int c = 0;
            do
            {
                Console.WriteLine("Do While ",c);
                c++;

            } while (c < 10);


            //Foreach


        }
    }
}
