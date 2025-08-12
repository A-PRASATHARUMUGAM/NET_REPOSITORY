
namespace ConsoleApp1
{

    class Program
    {

        static void Main(string[] args)
        {


            //DataTypes and variable Declaration 
            int a = 18;
            long c = 24;
            float b = 20;
            double d = 10;
            string name = "prasath ";
            string num1 = "1";
            Boolean fila = true;

            Console.WriteLine(fila);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());

            //Getting Input 
            Console.WriteLine("Enter the first value ");
            string value1 = Console.ReadLine();
            Console.WriteLine("Enter the first value 2");
            string value2 = Console.ReadLine();

            int add1 = int.Parse(value1);
            int add2 = int.Parse(value2);

            Console.WriteLine(add1 + add2);



            //Type Conversion again



            //implicit conversion

            //int to long 
            //float to double

            //Explicit Conversion 


            //int to float 
            int decml = 22;
            float conv = (float)decml;
            Console.WriteLine(conv.GetType());    

                        //String to int
            string str = "100";
            int name2 = int.Parse(str);
            int name3 = Convert.ToInt32(str);
            Console.WriteLine(name2.GetType());

          

        }
    }
}
