
public class Program
{


    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }

    public static void Main(string[] args)
    {
        Model model = new Model();

        List<Model> checkList = new List<Model>{
            new Model{ Id= 1 , Name="prasath",Desc= "program"},
            new Model{ Id= 2 , Name="sabari",Desc= "program"},
            new Model{ Id= 3 , Name="vignesh",Desc= "program"},
            new Model{ Id= 1 , Name="karthi",Desc= "program"},
        };

        foreach (var check in checkList)
        {
            Console.WriteLine($"Id: {check.Id}, Name: {check.Name}, Desc: {check.Desc}");
        }
        ;

        Console.WriteLine("Enter the Id to Remove the Value");

        int idToRemove = int.Parse(Console.ReadLine());

        var item = checkList.FirstOrDefault(x => x.Id == idToRemove);

        if (item != null)
        {
            checkList.Remove(item);
            Console.WriteLine("Item removed successfully", item);
        }
        else
        {
            Console.WriteLine("Item not Found");
        }

        foreach (var check in checkList)
        {
            Console.WriteLine($"Id: {check.Id}, Name: {check.Name}, Desc: {check.Desc}");
        }
        ;
    }

}