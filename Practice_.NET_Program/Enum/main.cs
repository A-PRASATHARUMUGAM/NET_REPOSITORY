namespace Practice_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Enumpg enumpg = Enumpg.Monday;

            Console.WriteLine(enumpg);

            //Convert to int
            int count = (int)Enumpg.Tuesday;

            //index value to print
            Enumpg tuesval = (Enumpg)4;

            Console.WriteLine(tuesval);

            //GetValues
            foreach (var val in Enum.GetValues(typeof(Enumpg)))
            {
                Console.WriteLine(val);
            }
        }
    }

    public enum Enumpg
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
}