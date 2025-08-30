namespace Practice_Program.Generics
{
    public class Generics_Program
    {
        public void display()
        {
            Console.WriteLine("check generics");
        }

        //using generics
        public static bool IsEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }

    public class Myclass<T>
    {
        public void compare<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}