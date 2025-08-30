namespace Practice_Program
{
    public class Program
    {
        //        The.Net Framework provides two types of attributes

        //1. pre-defined attributes
        //The.Net Framework provides "three" pre-defined attributes
        //AttributeUsage
        //Conditional
        //Obsolete
        //Example for Pre-defined attribute [WebMethod], [Obsolete], [Serializable], [ThreadStatic]

        //2.User defined attributes.

        public static void Main(String[] args)
        {
            //ReflectionAttribute reflectionAttribute = new ReflectionAttribute();

            Program program = new Program();

            //If true → throw error, stop compilation.
            //If false → show warning, but still compile.
            program.OldMethod();
        }

        [Obsolete("Don't use OldMethod , use NewMethod insted", false)]
        public void OldMethod()
        {
            Console.WriteLine("Old Method");
        }

        public void NewMethod()
        {
            Console.WriteLine("New Method");
        }

        
    }
}