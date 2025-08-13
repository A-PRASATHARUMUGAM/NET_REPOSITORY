
namespace Practice_.NET_Program
{
     class Looping_Statement()
    {


                    //         LOOPS
        // For
        // While (check then run code block)
        // Do while (run code block then it will check)
        // Foreach in (loop through array or list)
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


            //Foreach in

            //Array 
            Console.WriteLine("Collect ");
            int[] arr = new int[5];


            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;

            //Console.WriteLine(arr[2]);

            //ForEach
            foreach (int val in arr)
            {

                Console.WriteLine(val);
            }
        }
    }
}
