using Practice_Program.Generics;

namespace Practice_Program
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //Generics  - it is type independent using <T> / create type saftey class and methods

            Generics_Program generics = new Generics_Program();

            Myclass<int> myclass = new Myclass<int>();

            //IsEqual()  -- it is get the two integer number the check it is equal or not

            bool isEqual = Generics_Program.IsEqual<int>(7, 5);

            Console.WriteLine(isEqual);

            // Another class using generics

            myclass.compare<int>(5, 5);
        }
    }
}